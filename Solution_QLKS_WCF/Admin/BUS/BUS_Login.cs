using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.GUI;

namespace Admin.BUS
{
    public class BUS_Login
    {
        private static BUS_Login instance;
        public static BUS_Login DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Login();
                }
                return instance;
            }
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public static bool space(string input)
        {
            string specialChar = " ";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public bool dangnhap(String tendangnhap, String matkhau)
        {
            if(tendangnhap.Trim().Length > 0 && matkhau.Trim().Length > 0)
            {
                if(hasSpecialChar(tendangnhap.Trim()) || hasSpecialChar(matkhau.Trim()))
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if(matkhau.Trim().Length > 7 && matkhau.Trim().Length < 21)
                    {
                        if(space(tendangnhap.Trim()) || space(matkhau.Trim()))
                        {
                            MessageBox.Show("Tên đăng nhập và mật khẩu không được có khoảng trắng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }    
                        else
                        {
                            if (Program.qlks.Login(tendangnhap.Trim(), matkhau.Trim()))
                            {
                                if (Program.qlks.kiemtratt(tendangnhap.Trim()))
                                {
                                    if(Program.qlks.layquyen(tendangnhap) == 0)
                                    {
                                        if (Program.qlks.ktvohieuhoa(tendangnhap))
                                        {
                                            MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Đăng nhập thành công", "Thông báo");
                                            return true;
                                        }
                                    }
                                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Người dùng đang ONLINE", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }    
                    }  
                    else
                    {
                        MessageBox.Show("Mật khẩu phải từ 8 đến 20 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }    
                }
            }   
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void themsocket(string tendangnhap)
        {
            Program.qlks.themsocket(tendangnhap);
        }

        public void doimatkhau(TextBox mkcu, TextBox mkmoi, TextBox nhaplai, String user)
        {
            if(mkcu.Text.Trim().Length > 0 && mkmoi.Text.Trim().Length > 0 && nhaplai.Text.Trim().Length > 0)
            {
                if (hasSpecialChar(mkcu.Text.Trim()) || hasSpecialChar(mkmoi.Text.Trim()) || hasSpecialChar(nhaplai.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu không được có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mkmoi.Text.Trim().Length > 7 && mkmoi.Text.Trim().Length < 21)
                    {
                        if (space(mkcu.Text.Trim()) || space(mkmoi.Text.Trim()) || space(nhaplai.Text.Trim()))
                        {
                            MessageBox.Show("Mật khẩu không được có khoảng trắng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (mkmoi.Text.Trim() != nhaplai.Text.Trim())
                            {
                                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (Program.qlks.kiemtramatkhaucu(user.Trim(), mkcu.Text.Trim()))
                                {
                                    Program.qlks.doimatkhau(user.Trim(), mkmoi.Text.Trim());
                                    mkcu.Text = "";
                                    mkmoi.Text = "";
                                    nhaplai.Text = "";
                                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải từ 8 đến 20 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }  
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
