using System;
using System.Runtime.InteropServices;
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
        public static void MatchRecord(OptType tp, string opt)
        {
            int len = 0;
            using (FileStream fs = new FileStream("Record.dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(Record));
            }
            Record rec = new Record();
            try
            {
                for (int i = 1; i < len / 2; i++)
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
        public static T FindObjByID<T>(string id)where T:ICheck, new()
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