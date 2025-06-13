using System;

namespace Kutuphane_Takip_Sistemi
{
    public interface IOduncAlabilir
    {
        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);
    }
}
