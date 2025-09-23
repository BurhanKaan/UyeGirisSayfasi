using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UyeGirisSistemi
{
    public partial class Index : System.Web.UI.Page
    {
        DataModel model = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kadi.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_sifre.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_mail.Text.Trim()))
                    {
                        if (tb_mail.Text.Contains("@"))
                        {
                            Uyeler u = model.UyeGiris(tb_kadi.Text.Trim(), tb_sifre.Text.Trim(), tb_mail.Text.Trim());
                            if (u != null)
                            {
                                pnl_mesaj.Visible = true;
                                lbl_mesaj.Text = "Giriş Başarılı";
                            }
                            else
                            {
                                pnl_mesaj.Visible = true;
                                lbl_mesaj.Text = "Kullanıcı bulunamadı";
                            }
                        }
                        else
                        {
                            pnl_mesaj.Visible = true;
                            lbl_mesaj.Text = "Lütfen geçerli bir email adresi giriniz";
                        }
                    }
                    else
                    {
                        pnl_mesaj.Visible=true;
                        lbl_mesaj.Text = "Lütfen boş bırakmayın";
                    }
                }
                else
                {
                    pnl_mesaj.Visible = true;
                    lbl_mesaj.Text = "Şifre Geçersiz";
                }
            }
            else
            {
                pnl_mesaj.Visible=true;
                lbl_mesaj.Text = "Kullanıcı adı geçersiz";
            }
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text.Trim())) 
            {
                if (!string.IsNullOrEmpty(tb_soyisim.Text.Trim()))  
                {
                    if (!string.IsNullOrEmpty(tb_mail.Text.Trim())) 
                    {
                        if (tb_mail.Text.Contains("@")) 
                        {
                            if (!string.IsNullOrEmpty(tb_kadi.Text.Trim())) 
                            {
                                if (!string.IsNullOrEmpty(tb_sifre.Text.Trim()))    
                                {
                                    Uyeler u = model.UyeKayit(tb_isim.Text.Trim(), tb_soyisim.Text.Trim(), tb_mail.Text.Trim(), tb_kadi.Text.Trim(), tb_sifre.Text.Trim());
                                    if (u != null)
                                    {
                                        Response.Redirect("Index.aspx");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}