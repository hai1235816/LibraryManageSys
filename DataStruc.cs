using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

interface IGet
{
    string GetID();
}

interface ICheck
{
    bool Check();
}

namespace Lib_Mana_Sys
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BookMaster:IGet
    {
        uint master_id;
        uint total_num;
        uint reserved_num;
        uint lent_num;
        Book info;
        
        public BookMaster(uint total, Book book)
        {
            total_num = total;
            reserved_num = 0;
            lent_num = 0;
            info = book;
            master_id = book.Master_id;
        }
        public uint Total_num { get => total_num; }
        public uint Reserved_num { get => reserved_num; }
        public uint Access_num { get => total_num - lent_num - reserved_num - 1; }
        public uint Lent_num { get => lent_num; }
        public uint Master_ID { get => master_id; }
        public Book Info { get => info; }
        public bool CanBook() { return lent_num > reserved_num; }
        public bool CanLend() { return Access_num > 0; }
        public void beLent()
        {
            //若借书的时候已经无书可借，说明用户是来取预约的书的，否则是来正常借书的
            if (Access_num > 0) lent_num++;
            else reserved_num--;
        }
        public void beBooked()
        {
            reserved_num++;
        }
        public void beReturned()
        {
            lent_num--;
            //预约的记录开始生效
            if (Reserved_num > 0)
            {
                try
                {
                    Record rec = new Record();
                    for(int i=0; ; i++)
                    {
                        rec = FileDate.ReadOne<Record>(i);
                        if (rec.Unmatch && rec.Optor == GetID())
                        {
                            rec.Unmatch = false;
                        }
                        //只查找最近一个月内的记录
                        if (rec.spanDaysToPresent() > 31) break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }
        //emmmmm如果丢失怎么办？
        public void beLost()
        {

        }
        public string GetID() { return master_id.ToString(); }
    }

    public enum BookType
        {
            政治理论与政治主义,
            哲学宗教,
            社会科学总论,
            政治法律,
            军事,
            经济,
            文化科学教育体育,
            语言文字,
            文学,
            艺术,
            历史地理,
            自然科学总论,
            数理科学与化学,
            天文学与地球科学,
            生物科学,
            医药卫生,
            农业科学,
            工业技术,
            交通运输,
            航空航天,
            环境科学与安全科学,
            综合性图书
        };
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct Book
    {
        uint master_id;
        uint type;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.BOOK_NAME_SIZE)]
        string name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.ISBN_SIZE)]
        string iSBN;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.BOOK_PRESS_SIZE)]
        string press;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.BOOK_AUTHOR_SIZE)]
        string author;

        public Book(string bname, string isbn, string publish, string auth, BookType bookType, uint id)
        {
            master_id = id;
            name = bname;
            iSBN = isbn;
            press = publish;
            author = auth;
            type = (uint)bookType;
        }
        public BookType Type { get => (BookType)type; }
        public string Name { get => name; set => name = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
        public string Press { get => press; set => press = value; }
        public string Author { get => author; set => author = value; }
        public uint Master_id { get => master_id; }
    }

    public enum Privilege { 游客, 学生, 职工, 管理员 };
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct User:IGet
    {
        private bool valid;
        private bool gender;
        private uint reserveid;
        private float balance;
        private Privilege pri;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = ConstVar.USER_BOOKBORROW_SIZE)]
        private uint[] borrowBook;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.USER_ID_SIZE)]
        private string id; //12位(可少于12位)
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.USER_NAME_SIZE)]
        private string name;//20位姓名（可少于20位）
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstVar.USER_PWD_SIZE)]
        private string pwd; //16位密码（可少于16位）
        //--------------------------*-----------------------------------
        public User(bool ismale, Privilege p, string uid, string nam, string passw)
        {
            valid = true;
            gender = ismale;
            pri = p;
            id = uid;
            name = nam;
            pwd = passw;
            borrowBook = new uint[ConstVar.USER_BOOKBORROW_SIZE];
            reserveid = 0;
            balance = 20.0f;
        }
        public User(string visName)
        {
            valid = true;
            gender = true;
            pri = Privilege.游客;
            id = null;
            name = visName;
            pwd = null;
            borrowBook = new uint[ConstVar.USER_BOOKBORROW_SIZE];
            reserveid = 0;
            balance = 0.0f;
        }
        public User(User u)
        {
            valid = u.Valid;
            gender = u.Gender;
            pri = u.Pri;
            id = u.ID;
            name = u.Name;
            pwd = u.Pwd;
            borrowBook = new uint[ConstVar.USER_BOOKBORROW_SIZE];
            reserveid = 0;
            balance = u.Balance;
        }
        public bool Valid { get { return valid; } set { valid = value; } }
        public bool Gender { get { return gender; } }
        public Privilege Pri { get { return pri; } }
        public string ID { get { return id; } }
        public string Pwd { get { return pwd; } set { pwd = value; } }
        public string Name { get { return name; } set { name = value; } }
        public uint Reserveid { get => reserveid; set => reserveid = value; }
        public float Balance { get => balance; set => balance = value; }
        public bool ChargeVal { get => Balance >= 0.0f; }
        public int Borrownum
        {
            get
            {
                int count = 0;
                for(int i = 0; i < ConstVar.USER_BOOKBORROW_SIZE; i++)
                {
                    if (this[i] != 0) count++;
                }
                return count;
            }
        }
        public string GetID() { return ID; }
        public uint this[int index]
        {
            get
            {
                if (index < 0 || index > ConstVar.USER_BOOKBORROW_SIZE - 1) return 0;
                else return borrowBook[index];
            }
            set
            {
                if (index > -1 && index < ConstVar.USER_BOOKBORROW_SIZE)
                {
                    borrowBook[index] = value;
                }
            }
        }
        //借阅 * 预约
        public void borrowFrom(ref BookMaster master)
        {
            if (master.CanLend())
            {
                for (int i = 0; i < ConstVar.USER_BOOKBORROW_SIZE; i++)
                {
                    if (this[i] == 0)
                    {
                        this[i] = master.Master_ID;
                        master.beLent();
                        if (master.Master_ID == Reserveid)
                        {
                            Reserveid = 0;
                            //用户完成预约记录
                            FileDate.MatchRecord(OptType.预约, ID);
                        }
                        //创建借阅记录
                        FileDate.WriteInfo(new Record(OptType.借阅, ID, master.GetID(), ConstVar.BORROW_DURING_DAYS));
                        MessageBox.Show("记得按时归还哦", "操作成功");
                        break;
                    }
                    if (i == ConstVar.USER_BOOKBORROW_SIZE - 1)
                    {
                        MessageBox.Show("你的借书数量达上限，不可以借阅其他书籍", "提示信息");
                    }
                }
            }
            else
            {
                MessageBox.Show("书籍暂不可被借阅，可尝试预约或馆内阅读.", "温馨提示");
            }
        }
        public void reserveFrom(ref BookMaster master)
        {
            if (master.Access_num > 0)
            {
                MessageBox.Show("馆内有可借出的书哦，现在就可以去借来啦", "温馨提示");
                return;
            }
            if (master.CanBook())
            {
                if (Reserveid == 0)
                {
                    reserveid = master.Master_ID;
                    master.beBooked();
                    //产生记录
                    FileDate.WriteInfo<Record>(new Record(OptType.预约, ID, master.GetID(), 0));
                    MessageBox.Show("你的书成功被预约，记得早点来取", "预约成功");
                    return;
                }
                MessageBox.Show("当前预约结束前不可以预约其它书", "预约失败");
            }
            else
            {
                MessageBox.Show("借出的书已经全部被预约啦！", "下次早点来");
            }
        }
        //归还图书，从实际角度考虑，此方法一定能达到效果，不需要额外判断
        public void givebackTo(ref BookMaster master)
        {
            master.beReturned();
            FileDate.MatchRecord(OptType.借阅, ID);
        }
        //同步自身状态，例如书籍是否逾期
        public void Syncr()
        {

        }
    }

    public enum OptType { 借阅, 冻结, 预约, 损坏, 续借 };
    //我们只记录五种操作：借书，冻结，预约，损坏（书籍等），续借
    //其它的操作如还书，解冻，完成预约，会在原来的记录上记录(unmatch为true)表示已经被完成
    //而单独存在的记录如损坏，续借，unmatch会直接设置为true
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct Record
    {
        //是否为历史记录
        bool unmatch;
        uint type;
        int year;
        int month;
        int day;
        //操作持续时长
        int durDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        string optor;//操作者
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        string objer;//操作对象
        //--------------------------------------------------------
        public Record(OptType tp, string opt, string obj, int during)
        {
            type = (uint)tp;
            optor = opt;
            objer = obj;
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            durDay = during;
            unmatch = tp != OptType.损坏 && tp != OptType.续借;
        }
        public OptType Type { get => (OptType)type; }
        public int Year { get => year; }
        public int Month { get => month; }
        public int Day { get => day; }
        public int Dur { get => durDay; set => durDay = value; }
        public string Optor { get => optor; set => optor = value; }
        public string Objer { get => objer; set => objer = value; }
        public bool Unmatch { get => unmatch; set => unmatch = value; }
        //记录完成，成为历史记录
        public Record findMatch()
        {
            if (Type != OptType.损坏 && Type != OptType.续借)
            {
                Dur = spanDaysToPresent();
                Unmatch = false;
            }
            return this;
        }
        public int spanDaysToPresent()
        {
            DateTime here = new DateTime(Year, Month, Day);
            return (DateTime.Now - here).Days;
        }
        public void debug()
        {
            string info = "";
            switch ((OptType)type)
            {
                case OptType.借阅:
                    info = "用户" + Optor + "借阅了编号为" + Objer + "的书，";
                    info += Unmatch ? "尚未归还" : "已经归还";
                    break;
                case OptType.冻结:
                    info = "用户" + Optor + "冻结了" + Objer + "的权限，";
                    info += Unmatch ? "尚未解冻" : "已经解冻";
                    break;
                case OptType.预约:
                    info = "用户" + Optor + "预约了编号为" + Objer + "的书，";
                    info += Unmatch ? "预约未完成" : "预约完成";
                    break;
                case OptType.续借:
                    info = "用户" + Optor + "续借了编号为" + Objer + "的书，";
                    break;
                case OptType.损坏:
                    info = "用户" + Optor + "损坏了编号为" + Objer + "的书，";
                    break;
                default:
                    break;
            }
            if (info != "")
            {
                info += "\t" + new DateTime(Year, Month, Day).ToString();
                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}