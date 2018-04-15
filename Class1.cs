using System;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    static class FileDate
    {
        //通过ISBN来找到书籍（书籍ISBN是唯一的，可以当做一个标识）
        public static List<BookMaster> SearchByISBN(string isbn)
        {
            BookMaster master = new BookMaster();
            uint count = FileDate.CountOf<BookMaster>();
            List<BookMaster> bklist = new List<BookMaster>(1);
            for (int i = 0; i < count; i++)
            {
                master = FileDate.ReadOne<BookMaster>(i);
                if (master.Info.ISBN.Contains(isbn))
                {
                    bklist.Add(master);
                    break;
                }
            }
            if (bklist.Count == 0)
            {
                MessageBox.Show("未找到该ISBN编号的书", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return bklist;
        }
        //对象是否已经存在
        public static bool Exist<T>(T t) where T:IGet,new()
        {
            try
            {
                T t2 = new T();
                for(int i=0; ; i++)
                {
                    t2 = FileDate.ReadOne<T>(i);
                    if (t.GetID().ToLower() == t2.GetID().ToLower() || t.GetName().ToLower() == t2.GetName().ToLower())
                    return true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            return false;
        }
        //文件中对象个数
        public static uint CountOf<T>()where T:new()
        {
            T t = new T();
            long len = 0;
            string filename = t.ToString() + ".dat";
            if (!File.Exists(filename)) return 0;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                len = fs.Length / Marshal.SizeOf(typeof(T));
            }
            return Convert.ToUInt32(len);
        }
        //与以前的记录匹配，成为历史记录
        public static void MatchRecord(OptType tp, string opt, string obj)
        {
            if (!File.Exists("Lib_Mana_Sys.User.dat")) return;
            int len = 0;
            using (FileStream fs = new FileStream("Lib_Mana_Sys.Record.dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(Record));
            }
            Record rec = new Record();
            for (int i = 1; i <= len ; i++)
            {
                rec = FileDate.ReadOne<Record>(len - i);
                if (rec.Unmatch && rec.Type == tp && rec.Optor == opt && rec.Objer == obj)
                {
                    FileDate.AlterInfo(rec.findMatch());
                    break;
                }
            }
        }
        //根据索引读取一个对象
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
        //新存储一个对象
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
        //对象的值发生变化，更新值
        public static void AlterInfo<T>(T t)where T:IGet,new()
        {
            int structsize = Marshal.SizeOf(typeof(T));
            uint count = FileDate.CountOf<T>();
            using(FileStream fs = new FileStream(t.ToString() + ".dat", FileMode.Open))
            {
                using(BinaryReader br = new BinaryReader(fs))
                {
                    for (uint i = 0; i < count; i++)
                    {
                        if (Byte2Struct<T>(br.ReadBytes(structsize)).GetID() == t.GetID())
                        {
                            using(BinaryWriter bw = new BinaryWriter(fs))
                            {
                                fs.Position -= structsize;
                                bw.Write(Struct2Byte<T>(t));
                            }
                            return;
                        }
                    }
                }
            }
        }
        //删除对象（相当于将对象变为默认值）
        public static void Delete<T>(T t)where T:IGet,new()
        {
            int structsize = Marshal.SizeOf(typeof(T));
            uint count = FileDate.CountOf<T>();
            using (FileStream fs = new FileStream(t.ToString() + ".dat", FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    for (uint i = 0; i < count; i++)
                    {
                        if (Byte2Struct<T>(br.ReadBytes(structsize)).GetID() == t.GetID())
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                fs.Position -= structsize;
                                bw.Write(Struct2Byte<T>(new T()));
                            }
                            return;
                        }
                    }
                }
            }
        }
        //根据ID找到对象
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
        //底层的文件存储函数
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
    //public const int MAX_BOOKVIEW_NUM = 30;
    public const float FINE_IF_UNFINISHED = 2.0f;
    public const float FINE_IFNOT_RETURN_EVERYDAY = 5.0f;
    public const int MAX_RECORD_SEARCH_DAY = 180;
    public const int RESERVE_DAYS_FOR_BOOK = 3;
}