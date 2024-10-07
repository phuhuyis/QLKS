using Service.DAO;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service
{
    public class Server
    {
		static List<Socket> lsocket = new List<Socket>();
        IPAddress address = IPAddress.Parse(config.ipsocket);
		public Server()
		{
			Thread t1 = new Thread(() =>
			{
				TcpListener listener = new TcpListener(address, config.portsocket);
				listener.Start();
				while (true)
				{
					Socket socket = listener.AcceptSocket();
					lsocket.Add(socket);
				}
			});
			t1.Start();
		}
		//quan ly he thong
		public bool Login(String tendangnhap, String matkhau)
		{
			return DAO_Login.DAO.dangnhap(tendangnhap, matkhau);
		}

		public void dangxuat(String tendangnhap)
		{
			DAO_Login.DAO.dangxuat(tendangnhap);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if(DAO_Login.luser[i] == tendangnhap)
                {
					if(lsocket.ElementAt(i).Connected)
                    {
						try
                        {
							var stream = new NetworkStream(lsocket.ElementAt(i));
							var writer = new StreamWriter(stream);
							writer.AutoFlush = true;
							writer.WriteLine("dangxuat");
							lsocket.RemoveAt(i);
							DAO_Login.luser.RemoveAt(i);
							i--;
						}
						catch(Exception)
                        {
							lsocket.RemoveAt(i);
							DAO_Login.luser.RemoveAt(i);
							i--;
						}
					}		
					else
                    {
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
			}
		}

		public bool kiemtratt(String tendangnhap)
		{
			return DAO_Login.DAO.kiemtratt(tendangnhap);
		}

		public bool kiemtramatkhaucu(String tendangnhap, String matkhau)
        {
			return DAO_Login.DAO.kiemtramatkhaucu(tendangnhap, matkhau);
        }

		public void doimatkhau(String tendangnhap, String matkhau)
        {
			DAO_Login.DAO.doimatkhau(tendangnhap, matkhau);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("doimatkhau");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public void themsocket(string tendangnhap)
		{
			DAO_Login.DAO.themuser(tendangnhap);
		}
		public bool ktvohieuhoa(String tendangnhap)
		{
			return DAO_Login.DAO.ktvohieuhoa(tendangnhap);
		}

		public int layquyen(String tendangnhap)
        {
			return DAO_Login.DAO.layquyen(tendangnhap);
        }

		//quan ly nhan vien
		public String taomanv()
        {
			DataTable dt = dataprovider.Dataprovider.cautv("taomanv", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "nv001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "nv";
				if (a >= 100)
				{
					d += a.ToString();
				}
				else
				{
					if (a >= 10)
					{
						d += "0" + a.ToString();
					}
					else
					{
						d += "00" + a.ToString();
					}
				}
			}
			return d;
		}

		String taomk(DateTime ns)
		{
			String a = "";
			String b = "";
			String c = "";
			if(ns.Day < 10)
            {
				a = "0" + ns.Day.ToString();
			}
			else
            {
				a = ns.Day.ToString();
			}
			if(ns.Month < 10)
            {
				b = "0" + ns.Month.ToString();
			}
			else
            {
				b = ns.Month.ToString();
			}
			c = ns.Year.ToString();
			return a + b + c;
		}

        public void themnv(DataTable table, String tendangnhap)
        {
			foreach(DataRow row in table.Rows)
            {
				DTO_nhanvien item = new DTO_nhanvien(taomanv(), row[1].ToString(), DateTime.Parse(row[2].ToString()), row[3].ToString(), row[4].ToString(), row[5].ToString(), int.Parse(row[6].ToString()), 0, long.Parse(row[7].ToString()), double.Parse(row[8].ToString()), taomanv());
				DAO_nhanvien.DAO.them(item, encrytion.Encrypt(taomk(DateTime.Parse(row[2].ToString()))));
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themnv");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable searchnv(String key)
        {
			return DAO_nhanvien.DAO.search(key);
        }

		public void xoanv(String manv)
		{
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (DAO_Login.luser[i] == manv)
				{
					if(lsocket.ElementAt(i).Connected)
                    {
						try
						{
							var stream = new NetworkStream(lsocket.ElementAt(i));
							var writer = new StreamWriter(stream);
							writer.AutoFlush = true;
							writer.WriteLine("dangxuat");
							lsocket.RemoveAt(i);
							DAO_Login.luser.RemoveAt(i);
							i--;
						}
						catch (Exception)
						{
							lsocket.RemoveAt(i);
							DAO_Login.luser.RemoveAt(i);
							i--;
						}
					}
					else
                    {
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
			}
			dataprovider.Dataprovider.cautv("xoanv", new object[] { manv });		
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoanv");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("x" + manv);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable laydlnv(string manv)
		{
			DataTable table = DAO_nhanvien.DAO.laydl(manv);
			table.TableName = "capnhapnv";
			return table;
		}

		public void capnhapnv(DataTable table)
		{
			DataRow row = table.Rows[0];
			DTO_nhanvien item = new DTO_nhanvien(row[0].ToString(), row[1].ToString(), DateTime.Parse(row[2].ToString()), row[3].ToString(), row[4].ToString(), row[5].ToString(), int.Parse(row[6].ToString()), int.Parse(row[7].ToString()), long.Parse(row[8].ToString()), double.Parse(row[9].ToString()));
			DAO_nhanvien.DAO.capnhap(item);
			if (item.Tinhtrang == 1)
			{
				DAO_Login.DAO.dangxuat(item.Manv);
				for (int i = 0; i < lsocket.Count; i++)
				{
					if (String.Compare(DAO_Login.luser[i], item.Manv, true) == 0)
					{
						if (lsocket.ElementAt(i).Connected)
						{
							try
							{
								var stream = new NetworkStream(lsocket.ElementAt(i));
								var writer = new StreamWriter(stream);
								writer.AutoFlush = true;
								writer.WriteLine("dangxuat");
								lsocket.RemoveAt(i);
								DAO_Login.luser.RemoveAt(i);
								i--;
							}
							catch (Exception)
							{
								lsocket.RemoveAt(i);
								DAO_Login.luser.RemoveAt(i);
								i--;
							}
						}
						else
						{
							lsocket.RemoveAt(i);
							DAO_Login.luser.RemoveAt(i);
							i--;
						}
					}
				}
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("capnhapnv");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}				
		}

		//quan ly luong
		public bool kttinhluong()
		{
			DataTable table = dataprovider.Dataprovider.cautv("tinhluong", new object[] { });
			DataTable table1 = dataprovider.Dataprovider.cautv("bangtinhluong", new object[] { });
			if (table.Rows.Count > 0)
            {
				if (table.Rows.Count == table1.Rows.Count)
					return false;
				return true;
            }			
			else
				return true;
		}

		public DataTable loadluong()
        {
			DataTable table = DAO_luong.DAO.load();
			table.TableName = "loadluong";
			return table;
        }

		public bool ktnv()
        {
			DataTable table = DAO_luong.DAO.ktnv();
			if (table.Rows.Count > 0)
				return true;
			else
				return false;
        }

		public void tinhluong(DataTable table)
        {
			for(int i = 0; i < table.Rows.Count; i++)
            {
				DTO_luong item = new DTO_luong(taoluong(), table.Rows[i][1].ToString(), int.Parse(table.Rows[i][3].ToString()), long.Parse(table.Rows[i][4].ToString()));
				DAO_luong.DAO.themluong(item);
            }
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("tinhluong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public String taoluong()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomaphieuluong", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "ph001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "ph";
				if (a >= 100)
				{
					d += a.ToString();
				}
				else
				{
					if (a >= 10)
					{
						d += "0" + a.ToString();
					}
					else
					{
						d += "00" + a.ToString();
					}
				}
			}
			return d;
		}

		public void xoaluong()
        {
			dataprovider.Dataprovider.cautv("xoaluong", new object[] { });
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoaluong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable tkluong(String key)
        {
			DataTable table = dataprovider.Dataprovider.cautv("tkluong", new object[] { key });
			table.TableName = "tkluong";
			return table;
        }

		public DataTable tkluong2(String key)
		{
			DataTable table = dataprovider.Dataprovider.cautv("tkluong2", new object[] { key });
			table.TableName = "tkluong2";
			return table;
		}

		public DataTable loadluongcn(string maphieu)
		{
			DataTable table = DAO_luong.DAO.loadluongcn(maphieu);
			table.TableName = "loadluongcn";
			return table;
		}

		public void capnhapluong(DataTable table)
		{
			DataRow row = table.Rows[0];
			DTO_luong item = new DTO_luong(row[0].ToString(), int.Parse(row[1].ToString()), long.Parse(row[2].ToString()));
			DAO_luong.DAO.capnhapluong(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("capnhapluong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		//quan ly don vi cung cap
		public void themdonvicungcap(DataTable table)
        {
			for(int i = 0; i < table.Rows.Count; i++)
            {
				DTO_donvicungcap item = new DTO_donvicungcap(table.Rows[i][1].ToString(), table.Rows[i][2].ToString(), table.Rows[i][3].ToString());
				DAO_donvicungcap.DAO.them(item);
            }
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themdonvi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable tkdonvi(string key)
		{
			DataTable table = DAO_donvicungcap.DAO.tkdonvi(key);
			table.TableName = "tkdonvi";
			return table;
		}

		public void suadonvi(DataTable table)
		{
			DTO_donvicungcap item = new DTO_donvicungcap(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString());
			DAO_donvicungcap.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suadonvi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void xoadonvi(string madv)
		{
			DAO_donvicungcap.DAO.xoa(madv);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoadonvi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable load(string madv)
		{
			DataTable table = DAO_donvicungcap.DAO.load(madv);
			table.TableName = "loaddonvi";
			return table;
		}

		//nhap dich vu
		public DataTable loaddvcc()
        {
			DataTable table = DAO_nhapdichvu.DAO.loaddv();
			table.TableName = "loaddvcc";
			return table;
        }

		public string taohdnhap(string madv)
		{
			return DAO_nhapdichvu.DAO.taohdnhap(madv);
        }

		public void huyhd(string sohd)
		{
			DAO_nhapdichvu.DAO.huyhd(sohd);
		}

		public DataTable loaddichvu()
		{
			DataTable table = DAO_nhapdichvu.DAO.loaddichvu();
			table.TableName = "loaddichvu";
			return table;
		}

		public void nhapdichvu(DataTable table)
		{
			for(int i = 0; i < table.Rows.Count; i++)
            {
				DAO_nhapdichvu.DAO.nhapdv(table.Rows[i][0].ToString(), table.Rows[i][1].ToString(), long.Parse(table.Rows[i][2].ToString()), int.Parse(table.Rows[i][3].ToString()));
            }
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("nhapdichvu");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable xemhoadonnhapdichvu(String sohd)
		{
			DataTable table = DAO_nhapdichvu.DAO.inhoadon(sohd);
			table.TableName = "hdnhap";
			return table;
		}

		public DataTable timkiemhdnhap(String key)
        {
			DataTable table = DAO_nhapdichvu.DAO.timkiemhd(key);
			table.TableName = "timkiemhdnhap";
			return table;
        }

		public DataTable inhd(String sohd)
		{
			DataTable table = DAO_nhapdichvu.DAO.inhd(sohd);
			table.TableName = "inhoadonnhap";
			return table;
		}

		//system nhan vien
		public DataTable loadloaiphong()
		{
			DataTable table = DAO_systemnhanvien.DAO.loadloaiphong();
			table.TableName = "loadloaiphong";
			return table;
		}

		public DataTable loadphong(String loaiphong)
		{
			DataTable table = DAO_systemnhanvien.DAO.loadphong(loaiphong);
			table.TableName = "loadphong";
			return table;
		}
		//quan ly loai phong
		public void themloaiphong(DataTable table)
		{
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_loaiphong item = new DTO_loaiphong(table.Rows[i][1].ToString(), long.Parse(table.Rows[i][2].ToString()));
				DAO_loaiphong.DAO.them(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themloaiphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable tkloaiphong(string key)
		{
			DataTable table = DAO_loaiphong.DAO.tk(key);
			table.TableName = "tkloaiphong";
			return table;
		}

		public void xoaloaiphong(string ma)
		{
			DAO_loaiphong.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoaloaiphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void sualoaiphong(DataTable table)
		{
			DTO_loaiphong item = new DTO_loaiphong(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), long.Parse(table.Rows[0][2].ToString()));
			DAO_loaiphong.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("sualoaiphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadloaiphong(string madv)
		{
			DataTable table = DAO_loaiphong.DAO.load(madv);
			table.TableName = "loadloaiphong";
			return table;
		}
		//quan ly phong
		public void themphong(DataTable table)
		{
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_phong item = new DTO_phong(table.Rows[i][1].ToString(), table.Rows[i][2].ToString());
				DAO_phong.DAO.them(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public DataTable tkphong(string key)
		{
			DataTable table = DAO_phong.DAO.tk(key);
			table.TableName = "tkphong";
			return table;
		}

		public void xoaphong(string ma)
		{
			DAO_phong.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoaphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public void suaphong(DataTable table)
		{
			DTO_phong item = new DTO_phong(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString());
			DAO_phong.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suaphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadphongql(string madv)
		{
			DataTable table = DAO_phong.DAO.load(madv);
			table.TableName = "loadphong";
			return table;
		}

		public DataTable loadtbqlp()
		{
			DataTable table = DAO_phong.DAO.loadtb();
			table.TableName = "loadtbqlp";
			return table;
		}

		public DataTable loadtbtpqlp(string madv)
		{
			DataTable table = DAO_phong.DAO.loadtbtp(madv);
			table.TableName = "loadtbtpqlp";
			return table;
		}

		public DataTable ktphong(string madv)
		{
			DataTable table = DAO_phong.DAO.ktphong(madv);
			table.TableName = "ktphong";
			return table;
		}

		public void sapxeptb(DataTable table)
		{
			DAO_phong.DAO.xoa2(table.Rows[0][0].ToString());
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_tttp item = new DTO_tttp(table.Rows[i][0].ToString(), table.Rows[i][1].ToString(), int.Parse(table.Rows[i][2].ToString()));
				DAO_phong.DAO.them2(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("sapxeptb");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadtbtpqlp2(string madv)
		{
			DataTable table = DAO_phong.DAO.loadtbtp2(madv);
			table.TableName = "loadtbtpqlp2";
			return table;
		}

		//quan ly thiet bi
		public void themthietbi(DataTable table)
		{
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_thietbi item = new DTO_thietbi(table.Rows[i][1].ToString(), table.Rows[i][2].ToString(), decimal.Parse(table.Rows[i][3].ToString()));
				DAO_thietbi.DAO.them(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themthietbi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public DataTable tkthietbi(string key)
		{
			DataTable table = DAO_thietbi.DAO.tk(key);
			table.TableName = "tkthietbi";
			return table;
		}

		public void xoathietbi(string ma)
		{
			DAO_thietbi.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoathietbi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public void suathietbi(DataTable table)
		{
			DTO_thietbi item = new DTO_thietbi(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), decimal.Parse(table.Rows[0][3].ToString()));
			DAO_thietbi.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suathietbi");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadthietbiql(string madv)
		{
			DataTable table = DAO_thietbi.DAO.load(madv);
			table.TableName = "loadtb";
			return table;
		}
		//quan ly dich vu
		public void themdichvu(DataTable table)
		{
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_dichvu item = new DTO_dichvu(table.Rows[i][1].ToString(), table.Rows[i][2].ToString(), decimal.Parse(table.Rows[i][3].ToString()));
				DAO_dichvu.DAO.them(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themdichvu");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public DataTable tkdichvu(string key)
		{
			DataTable table = DAO_dichvu.DAO.tk(key);
			table.TableName = "tkdichvu";
			return table;
		}

		public void xoadichvu(string ma)
		{
			DAO_dichvu.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoadichvu");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public void suadichvu(DataTable table)
		{
			DTO_dichvu item = new DTO_dichvu(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), decimal.Parse(table.Rows[0][3].ToString()));
			DAO_dichvu.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suadichvu");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loaddichvuql(string madv)
		{
			DataTable table = DAO_dichvu.DAO.load(madv);
			table.TableName = "loaddichvu";
			return table;
		}

		//quan ly khach hang

		public void themkhachhang(DataTable table)
		{
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DTO_khachhang item = new DTO_khachhang(table.Rows[i][1].ToString(), table.Rows[i][2].ToString());
				DAO_khachhang.DAO.them(item);
			}
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("themkhachhang");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public DataTable tkkhachhang(string key)
		{
			DataTable table = DAO_khachhang.DAO.tk(key);
			table.TableName = "tkkhachhang";
			return table;
		}

		public void xoakhachhang(string ma)
		{
			DAO_khachhang.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoakhachhang");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}
		public void suakhachhang(DataTable table)
		{
			DTO_khachhang item = new DTO_khachhang(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString());
			DAO_khachhang.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suakhachhang");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadkhachhangql(string madv)
		{
			DataTable table = DAO_khachhang.DAO.load(madv);
			table.TableName = "loadkhachhang";
			return table;
		}

		//dat phong
		public DataTable loadkhdat()
		{
			DataTable table = DAO_datphong.DAO.loadkh();
			table.TableName = "loadkhdat";
			return table;
		}

		public void datphongkc(string makh, DateTime ngayden, string maphong)
		{
			DAO_datphong.DAO.datphong(new DTO_phieudatphong(makh, ngayden, maphong));
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("datphongkc" + maphong);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void datphongkm(string tenkh, string cmnd, DateTime ngayden, string maphong)
		{
			DAO_datphong.DAO.datphongkm(new DTO_phieudatphong("", tenkh, cmnd, ngayden, maphong));
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("datphongkm" + maphong);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public bool kiemtraphong(String maphong)
		{
			return DAO_datphong.DAO.kiemtraphong(maphong);
		}

		//thue phong
		public DataTable loadkhthue()
		{
			DataTable table = DAO_thuephong.DAO.loadkh();
			table.TableName = "loadkhthue";
			return table;
		}

		public void thuephongkc(string makh, string maphong, String manv)
		{
			DAO_thuephong.DAO.thuephong(new DTO_thuephong(makh, maphong, manv));
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("thuephongkc" + maphong);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void thuephongkm(string tenkh, string cmnd, string maphong, String manv)
		{
			DAO_thuephong.DAO.thuephongkm(new DTO_thuephong("", tenkh, cmnd, maphong, manv));
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("thuephongkm" + maphong);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void chuyen(String sophong, String manv)
        {
			DAO_thuephong.DAO.chuyen(sophong, manv);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("chuyenphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		//quan ly phieu dat phong
		public DataTable tkphieudatphong(string key)
		{
			DataTable table = DAO_phieudatphong.DAO.tk(key);
			table.TableName = "phieudatphong";
			return table;
		}

		public void xoaphieudatphong(string ma)
		{
			DAO_phieudatphong.DAO.xoa(ma);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoaphieudatphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void suaphieudatphong(DataTable table)
		{
			DTO_phieudatphong item = new DTO_phieudatphong(table.Rows[0][0].ToString(), DateTime.Parse(table.Rows[0][1].ToString()));
			DAO_phieudatphong.DAO.sua(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("suaphieudatphong");
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable loadphieudatphong(string ma)
		{
			DataTable table = DAO_phieudatphong.DAO.load(ma);
			table.TableName = "loadphieudatphong";
			return table;
		}

		//goi dich vu
		public String laysohd(String maphong)
		{
			return DAO_cthd.DAO.laysohd(maphong).Rows[0][0].ToString();
		}

		public DataTable loadbanggiadv()
		{
			DataTable table = DAO_cthd.DAO.loadbanggiadv();
			table.TableName = "banggiadv";
			return table;
		}

		public DataTable loaddvdagoi(String sohd)
		{
			DataTable table = DAO_cthd.DAO.loaddvdagoi(sohd);
			table.TableName = "dvdagoi";
			return table;
		}

		public DataTable loaddsdv()
		{
			DataTable table = DAO_cthd.DAO.loaddsdv();
			table.TableName = "dsdvhd";
			return table;
		}

		public void goidv(String sohd, String madv, int sl)
		{
			DTO_cthd item = new DTO_cthd(sohd, madv, sl);
			DAO_cthd.DAO.goidv(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("goidv" + sohd);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void capnhapdv(String sohd, String madv, int sl)
		{
			DTO_cthd item = new DTO_cthd(sohd, madv, sl);
			DAO_cthd.DAO.capnhapdv(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("capnhapdvhd" + sohd);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void xoadv(String sohd, String madv)
		{
			DTO_cthd item = new DTO_cthd(sohd, madv);
			DAO_cthd.DAO.xoadv(item);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("xoadvhd" + sohd);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public bool kiemtradvtontai(String sohd, String madv)
		{
			return DAO_cthd.DAO.kiemtradvtontai(sohd, madv);
		}

		public int laysldv(String ma)
		{
			return DAO_cthd.DAO.laysldv(ma);
		}

		public int laysldvhd(String sohd, String ma)
		{
			return DAO_cthd.DAO.laysldvhd(sohd, ma);
		}

		public bool kiemtrasohd(String sohd)
        {
			return DAO_cthd.DAO.kiemtratontaihd(sohd);
        }

		public void huyhdthue(String sohd)
		{
			DAO_cthd.DAO.huyhd(sohd);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("huyhd" + sohd);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public void thanhtoan(String sohd)
		{
			DAO_cthd.DAO.thanhtoan(sohd);
			for (int i = 0; i < lsocket.Count; i++)
			{
				if (lsocket.ElementAt(i).Connected)
				{
					try
					{
						var stream = new NetworkStream(lsocket.ElementAt(i));
						var writer = new StreamWriter(stream);
						writer.AutoFlush = true;
						writer.WriteLine("thanhtoan" + sohd);
					}
					catch (Exception)
					{
						lsocket.RemoveAt(i);
						DAO_Login.luser.RemoveAt(i);
						i--;
					}
				}
				else
				{
					lsocket.RemoveAt(i);
					DAO_Login.luser.RemoveAt(i);
					i--;
				}
			}
		}

		public DataTable inhdkodv(String sohd)
		{
			DataTable table = DAO_cthd.DAO.inhdkodv(sohd);
			table.TableName = "inhdkodv";
			return table;
		}

		public DataTable inhdcodv(String sohd)
		{
			DataTable table = DAO_cthd.DAO.inhdcodv(sohd);
			table.TableName = "inhdcodv";
			return table;
		}

		public bool kiemtratontaihdtt(String sohd)
		{
			return DAO_cthd.DAO.kiemtratontaihdtt(sohd);
		}

		public bool kiemtratontaihdcthd(String sohd)
		{
			return DAO_cthd.DAO.kiemtratontaihdcthd(sohd);
		}

		public DataTable tkhoadonthue(String key)
		{
			DataTable table = DAO_cthd.DAO.tk(key);
			table.TableName = "hoadonthue";
			return table;
		}

		public DataTable thongkedoanhthu_chart(DateTime ngaybatdau, DateTime ngayketthuc)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_chart(ngaybatdau, ngayketthuc);
			table.TableName = "thongkedoanhthu";
			return table;
		}

		public DataTable thongkedoanhthuhd_chart(DateTime ngaybatdau, DateTime ngayketthuc)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthuhd_chart(ngaybatdau, ngayketthuc);
			table.TableName = "thongkedoanhthuhd";
			return table;
		}

		public DataTable thongkedoanhthu_table(DateTime ngaybatdau, DateTime ngayketthuc)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_table(ngaybatdau, ngayketthuc);
			table.TableName = "thongkedoanhthutable";
			return table;
		}

		public DataTable thongkedoanhthu_chart_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_chart(nam);
			table.TableName = "thongkedoanhthunam";
			return table;
		}

		public DataTable thongkedoanhthuhd_chart_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthuhd_chart(nam);
			table.TableName = "thongkedoanhthuhdnam";
			return table;
		}

		public DataTable thongkedoanhthu_table_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_table(nam);
			table.TableName = "thongkedoanhthutablenam";
			return table;
		}

		public DataTable thongkedoanhthu_chart_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_chart_thang(thang, nam);
			table.TableName = "thongkedoanhthuthang";
			return table;
		}

		public DataTable thongkedoanhthuhd_chart_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthuhd_chart_thang(thang, nam);
			table.TableName = "thongkedoanhthuhdthang";
			return table;
		}

		public DataTable thongkedoanhthu_table_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkedoanhthu_table_thang(thang, nam);
			table.TableName = "thongkedoanhthutablethang";
			return table;
		}

		public DataTable thongkesolanthue_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkesolanthue_nam(nam);
			table.TableName = "thongkesolanthue_nam";
			return table;
		}

		public DataTable thongkesolanthue_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkesolanthue_thang(thang, nam);
			table.TableName = "thongkesolanthue_thang";
			return table;
		}

		public DataTable thongkesolanthue_kcngay(DateTime ngaybd, DateTime ngaykt)
		{
			DataTable table = DAO_thongke.DAO.thongkesolanthue_kcngay(ngaybd, ngaykt);
			table.TableName = "thongkesolanthue_kcngay";
			return table;
		}

		public DataTable thongkeluong_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkeluong_thang(thang, nam);
			table.TableName = "thongkeluong_thang";
			return table;
		}

		public DataTable thongkeluong_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkeluong_nam(nam);
			table.TableName = "thongkeluong_nam";
			return table;
		}

		public DataTable thongkehdthue_kcngay(DateTime ngaybd, DateTime ngaykt)
		{
			DataTable table = DAO_thongke.DAO.thongkehdthue_kcngay(ngaybd, ngaykt);
			table.TableName = "thongkehdthue_kcngay";
			return table;
		}

		public DataTable thongkehdthue_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkehdthue_thang(thang, nam);
			table.TableName = "thongkehdthue_thang";
			return table;
		}

		public DataTable thongkehdthue_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongkehdthue_nam(nam);
			table.TableName = "thongkehdthue_nam";
			return table;
		}

		public DataTable thongketienravao_kcngay(DateTime ngaybd, DateTime ngaykt)
		{
			DataTable table = DAO_thongke.DAO.thongketienravao_kcngay(ngaybd, ngaykt);
			table.TableName = "thongketienravao_kcngay";
			return table;
		}

		public DataTable thongketienravao_thang(int thang, int nam)
		{
			DataTable table = DAO_thongke.DAO.thongketienravao_thang(thang, nam);
			table.TableName = "thongketienravao_thang";
			return table;
		}

		public DataTable thongketienravao_nam(int nam)
		{
			DataTable table = DAO_thongke.DAO.thongketienravao_nam(nam);
			table.TableName = "thongketienravao_nam";
			return table;
		}
	}
}
