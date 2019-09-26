using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 综合练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过传参拿到父类
            Computer cpu = new Computer();
            MobileStorageDevice disk = new MobileDisk();
            MobileStorageDevice mp3 = new MP3();
            MobileStorageDevice up = new UP();
            cpu.CpuRead(disk);
            cpu.CpuWrite(disk);
            cpu.CpuRead(mp3);
            cpu.CpuWrite(mp3);
            cpu.CpuRead(up);
            cpu.CpuWrite(up);
            Console.ReadKey();

        }


        /// <summary>
        /// 可移动存储设备
        /// </summary>
        public abstract class MobileStorageDevice
        {
            public abstract void Read();
            public abstract void Write();
        }
        /// <summary>
        /// 移动硬盘
        /// </summary>
        public class MobileDisk : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是移动硬盘");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是移动硬盘");
            }
        }
        /// <summary>
        /// MP3
        /// </summary>
        public class MP3 : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是MP3");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是MP3");
            }
        }
        /// <summary>
        /// u盘
        /// </summary>
        public class UP : MobileStorageDevice
        {
            public override void Read()
            {
                Console.WriteLine("正在读取数据的是u盘");
            }

            public override void Write()
            {
                Console.WriteLine("正在写入数据的是u盘");
            }
        }

        public class Computer
        {
            public void CpuRead(MobileStorageDevice ms)
            {
                ms.Read();
            }

            public void CpuWrite(MobileStorageDevice ms)
            {
                ms.Write();
            }
        }
    }
}
