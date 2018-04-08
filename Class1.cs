using System;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    static class FileDate
    {
        public static List<Book> SearchByName(string name)
        {
            List<Book> bklist = new List<Book>();
            Book book = new Book();
            try
            {
                for (int i = 0; bklist.Count < ConstVar.MAX_BOOKVIEW_NUM; i++)
                {
                    book = FileDate.ReadOne<BookMaster>(i).Info;
                    if (book.Name.Contains(name))
                    {
                        bklist.Add(book);
                    }
                }
            }
            catch (ArgumentException)
            {
                return bklist;
            }
            return bklist;
        }
        public static List<Book> SearchByAuthor(string author)
        {
            List<Book> bklist = new List<Book>();
            Book book = new Book();
            try
            {
                for (int i = 0; bklist.Count < ConstVar.MAX_BOOKVIEW_NUM; i++)
                {
                    book = FileDate.ReadOne<BookMaster>(i).Info;
                    if (book.Author.Contains(author))
                    {
                        bklist.Add(book);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return bklist;
            }
            return bklist;
        }
        public static List<Book> SearchByISBN(string isbn)
        {
            List<Book> bklist = new List<Book>();
            Book book = new Book();
            try
            {
                for (int i = 0; bklist.Count < ConstVar.MAX_BOOKVIEW_NUM; i++)
                {
                    book = FileDate.ReadOne<BookMaster>(i).Info;
                    if (book.ISBN == isbn)
                    {
                        bklist.Add(book);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            return bklist;
        }
        public static List<Book> SearchByPress(string press)
        {
            List<Book> bklist = new List<Book>();
            Book book = new Book();
            try
            {
                for (int i = 0; bklist.Count < ConstVar.MAX_BOOKVIEW_NUM; i++)
                {
                    book = FileDate.ReadOne<BookMaster>(i).Info;
                    if (book.Press.Contains(press))
                    {
                        bklist.Add(book);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            return bklist;
        }
        //文件中对象个数
        public static int CountOf<T>()where T:new()
        {
            T t = new T();
            int len = 0;
            using (FileStream fs = new FileStream(t.ToString() + "dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(T));
            }
            return len + 1;
        }
        //分配一个新ID
        public static uint AllocID<T>() where T:new()
        {
            T t = new T();
            long len = 0;
            using(FileStream fs = new FileStream(t.ToString() + ".dat", FileMode.Open))
            {
                len = fs.Length / Marshal.SizeOf(typeof(T));
            }
            return Convert.ToUInt32(len + 1);
        }
        //查找近期的预约记录，若超过三天未来借书，此记录作废
        public static void updateRecord()
        {
            if (!File.Exists("Lib_Mana_Sys.Record")) return;
            int len = 0;
            using (FileStream fs = new FileStream("Lib_Mana_Sys.Record.dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(Record));
            }
            Record rec = new Record();
            try
            {
                for (int i = 1; i < len / 2; i++)
                {
                    rec = FileDate.ReadOne<Record>(len - i);
                    if (rec.Type == OptType.预约 && rec.Unmatch && rec.spanDaysToPresent() > 3)
                    {
                        rec.Dur = -1;
                        rec.Unmatch = false;
                        FileDate.WriteInfo(rec, len - i);
                        //用户违约，扣除金额
                        //这里相当于遍历了两次，需要优化!!!
                        User user = FileDate.FindObjByID<User>(rec.Optor);
                        user.Balance -= ConstVar.FINE_IF_UNFINISHED;
                        FileDate.WriteInfo(user, FileDate.GetIndex<User>(user));
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
        public static void MatchRecord(OptType tp, string opt)
        {
            if (!File.Exists("Lib_Mana_Sys.User.dat")) return;
            int len = 0;
            using (FileStream fs = new FileStream("Lib_Mana_Sys.Record.dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(Record));
            }
            Record rec = new Record();
            try
            {
                for (int i = 1; ; i++)
                {
                    rec = FileDate.ReadOne<Record>(len - i);
                    if (rec.Optor == opt && rec.Type == tp && rec.Unmatch)
                    {
                        FileDate.WriteInfo(rec.findMatch(), len - i);
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int GetIndex<T>(T t)where T:IGet,new()
        {
            try
            {
                T tt = new T();
                for(int i=0; ; i++)
                {
                    tt = FileDate.ReadOne<T>(i);
                    if (t.GetID()==t.GetID())
                    {
                        return i;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
        public static T ReadOne<T>(int index)where T:new()
        {
            T t = new T();
            int strusize = Marshal.SizeOf(typeof(T));
            using(FileStream fs = new FileStream(t.ToString() + ".dat", FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    fs.Position += index * strusize;
                    t = Byte2Struct<T>(br.ReadBytes(strusize));
                }
            }
            return t;
        }
        public static void WriteInfo<T>(T t)
        {
            string filename = t.ToString() + ".dat";
            FileStream fs;
            if (File.Exists(filename))
            {
                fs = new FileStream(filename, FileMode.Append);
            }
            else
            {
                fs = new FileStream(filename, FileMode.CreateNew);
            }
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Struct2Byte<T>(t));

            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public static void WriteInfo<T>(T t, int index)
        {
            string filename = t.ToString() + ".dat";
            int structsize = Marshal.SizeOf(typeof(T));
            FileStream fs = new FileStream(filename, FileMode.Open);
            fs.Position = index * structsize;
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Struct2Byte<T>(t));

            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public static T FindObjByID<T>(string id)where T:IGet, new()
        {
            try
            {
                for(int i=0; ; i++)
                {
                    if (FileDate.ReadOne<T>(i).GetID() == id)
                    {
                        return FileDate.ReadOne<T>(i);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("未找到用户信息！", "提示");
            }
            return new T();
        }
        private  static byte[] Struct2Byte<T>(T t)
        {
            int structSize = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[structSize];
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(structSize);
            //将结构体拷到分配好的内存空间
            Marshal.StructureToPtr(t, structPtr, false);
            //从内存空间拷到byte数组
            Marshal.Copy(structPtr, buffer, 0, structSize);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            return buffer;
        }
        private  static T Byte2Struct<T>(byte[] arr)
        {
            int structSize = Marshal.SizeOf(typeof(T));
            IntPtr ptemp = Marshal.AllocHGlobal(structSize);
            Marshal.Copy(arr, 0, ptemp, structSize);
            T t = (T)Marshal.PtrToStructure(ptemp, typeof(T));
            Marshal.FreeHGlobal(ptemp);
            return t;
        }
    }
}
public class ConstVar
{
        /// <summary>
        /// 这个类储存的是常量，类似于C, C++中的宏定义
        /// C#不支持宏定义（有宏定义但是和C,C++不同）
        /// </summary>
        public const int BOOK_NAME_SIZE = 20;
        public const int ISBN_SIZE = 14;
        public const int BOOK_AUTHOR_SIZE = 20;
        public const int BOOK_PRESS_SIZE = 20;
        public const int USER_ID_SIZE = 12;
        public const int USER_PWD_SIZE = 16;
        public const int USER_NAME_SIZE = 20;
        public const int USER_BOOKBORROW_SIZE = 5;
        public const int BORROW_DURING_DAYS = 31;
    public const int MAX_BOOKVIEW_NUM = 30;
    public const float FINE_IF_UNFINISHED = 2.0f;
}