using System;
using System.Runtime.InteropServices;

interface ICheck
{
    void disable();
}

public enum BookType { 政治理论与政治主义,
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
    综合性图书 };
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi, Pack = 1)]
public struct Book:ICheck
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.I1)]
    private bool flag;
    [FieldOffset(1)]
    [MarshalAs(UnmanagedType.I1)]
    private bool isPreserve;
    [FieldOffset(2)]
    [MarshalAs(UnmanagedType.I1)]
    private bool isLent;
    [FieldOffset(3)]
    [MarshalAs(UnmanagedType.I1)]
    private bool isBooked;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.U4)]
    private uint id;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
    private string name;
    [FieldOffset(28)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    private string iSBN;
    [FieldOffset(42)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
    private string publishing;
    [FieldOffset(60)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
    private string author;
    [FieldOffset(80)]
    private BookType type;
    //----------------------------*-------------------------------
    public Book(bool isPre,uint bid,string bname,string isbn,string publish,string auth,BookType bookType)
    {
        flag = true;
        isBooked = false;
        isLent = false;
        isPreserve = isPre;
        id = bid;
        name = bname;
        iSBN = isbn;
        publishing = publish;
        author = auth;
        type = bookType;
    }
    public bool Flag { get { return flag; } set { flag = value; } }
    public bool Lent { get { return isLent; } set { isLent = value; } }
    public bool Booked { get { return isBooked; } set { isBooked = value; } }
    public string Author { get { return author; } set { author = value; } }
    //public string BookerID { get { return bookerid; }set { bookerid = value; } }
    //public string BorrowerID { get { return borrowerid; } set { borrowerid = value; } }
    public bool Preserve { get { return isPreserve; } }
    public uint ID { get { return id; } }
    public string Name { get { return name; } }
    public string ISBN { get { return iSBN; } }
    public string Publishing { get { return publishing; } }
    /*public void lendTo(ref User u)
    {
        isLent = u.borrow(ref this);
    }*/
    public void disable() { Flag = false; }
}

public enum Privilege { 游客, 学生, 职工, 管理员 };
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct User:ICheck
{
    private bool valid;
    private int borrowedNum;
    private int borrowLimit;
    private Privilege pri;
    [MarshalAs(UnmanagedType.ByValArray,SizeConst = 5)]
    private uint[] reserveBook;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
    private string id; //12位（可少于12位）
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
    private string name;//12位姓名（可少于12位）
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
    private string pwd; //12位密码（可少于12位）
    //--------------------------*-----------------------------------
    public User(Privilege p, string uid, string nam, string passw)
    {
        valid = true;
        borrowedNum = 0;
        borrowLimit = (int)p + 4;
        pri = p;
        id = uid;
        name = nam;
        pwd = passw;
        reserveBook = new uint[borrowLimit];
    }
    public User(string visName)
    {
        valid = true;
        pri = Privilege.游客;
        borrowedNum = 0;
        borrowLimit = 0;
        id = null;
        name = visName;
        pwd = null;
        reserveBook = null;
    }
    public User(User u)
    {
        valid = u.Valid;
        borrowedNum = u.BorrowedNum;
        borrowLimit = u.BorrowLimit;
        pri = u.Pri;
        id = u.ID;
        name = u.Name;
        pwd = u.Pwd;
        reserveBook = new uint[borrowLimit];
    }
    public bool Valid { get { return valid; } set { valid = value; } }
    public Privilege Pri { get { return pri; } }
    public string ID { get { return id; } set { id = value; } }
    public string Pwd { get { return pwd; } set { pwd = value; } }
    public string Name { get { return name; } set { name = value; } }
    public uint this[int index]
    {
        get
        {
            if (index < 0 || index > BorrowLimit - 1) return 0;
            else return reserveBook[index];
        }
        set
        {
            if (index >= 0) {
                reserveBook[index] = value;
                BorrowedNum++;
            }
        }
    }
    public int BorrowedNum { get { return borrowedNum; } set { borrowedNum = value; } }
    public int BorrowLimit { get { return borrowLimit; } }
    public void disable() { Valid = false; }
    public bool borrow(ref Book book)
    {
        for(int i = BorrowedNum; i < BorrowLimit; i++)
        {
            if (this[i] == 0)
            {
                this[i] = book.ID;
                book.Lent = true;
                break;
            }
        }
        return book.Lent;
    }
    
}

enum OptType { Borrow, Return };
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
struct Record
{
    private OptType type;            //记录是借书还是还书？
    private int bkid;             //操作的书的编号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
    private string uid;
    //--------------------------------------------------------
    public Record(OptType tp, int bid, string userid)
    {
        type = tp;
        bkid = bid;
        uid = userid;
    }
    public OptType Type { get { return type; } }
    public string Userid { get { return uid; } }
    public int Bookid { get { return bkid; } }
}