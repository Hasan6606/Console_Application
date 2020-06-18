using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             

            Bu alttaki uygulamalarda ise c# programla dilinin console application uygulamalarım mevcuttur.En açık ve detaylı açıklamalarla umarım
            alttaki uygulamalar size az veya çok katkı ve belirli bir mantık oluşmasında yardımcı olmuştur.



             --------Uygulama_1-----
              Console.WriteLine("Bu iki tirnak arasina yazilanlar ekran ciktisi olur.");
              AÇIKLAMA=Burda ekrana (Bu iki tirnak arasina yazilanlar ekran ciktisi olur.) yazdırdık.Türkçe karakter(i,ü,ğ vb.) kullanımına dikkat ediniz.
              Türkçe karakter kullanmak istiyorsanız debug/options/text editör/general/utf-8 kısmından ayarlayabilirsiniz. */



            /*
             


            
        
             -----Uygulama_2-----
            
            
            
            Bu uygulamada girilen vize,final değerlerinin matematiksel hesabı ile ortalamayı hesaplayıp, 
             sonuca göre mesaj yazdırmaktadır.
              
            
            float vize, final; --->Bu satırda vize,final değişkenlerimizi FLOAT türünden tanımladık.Virgüllü sayı değerlerindeki işlemde bu değişken türünü tercihen kullanılmalıdır. 
            double ortalama;----->Bu satırda ortalama vize ve final değişkeninin matematiksel işlemlerinin aktarıldığı DOUBLE türündeki değişkendir.Virgüllü ve büyük kapasitedeki işlemler için tercih edilmiştir. 
            Console.WriteLine("Lütfen vize notunuzu giriniz:");--->Bu satırda vize notu kullanıcıdan istemek için yazdırılmış satırıdır.
            vize =float.Parse(Console.ReadLine()); --->Bu satırda vize notunu vize adlı değişkene atamak için yazdırılmış satırıdır.
            Console.WriteLine("Lütfen final notunuzu giriniz:");--->Bu satırda final notu kullanıcıdan istemek için yazdırılmış satırıdır.
            final =float.Parse(Console.ReadLine());--->Bu satırda final notunu vize adlı değişkene atamak için yazdırılmış satırıdır.
            ortalama = ((vize * 4) + (final*6))/10;--->Bu satırda ortalama hesaplamak için matematiksel işlem yapılmıştır(Lütfen matematiksel işlemlerde işlem önceliğine dikkat ediniz.).
            if (ortalama >= 50)   ---->Bu satırda ise (if) koşul yapısı kullanılmıştır.Eğer parantez içindeki istenilen durum doğru ise süslü parantez içindeki işlemi yapar değilse alt satırlara geçiş olur.
            {
                Console.WriteLine("Tebrikler,Dersinizi {0} geçtiniz.",ortalama); --->Bu satırda ise koşulun içindeki şart sağlanınca olucak işlemdir.
            }
            else {    --->Bu ifade ise if yapısındaki şart sağlanmadığında bu ifadenin altta görmüş olduğunuz süslü parantezin içindeki çalışır.
                Console.WriteLine("Malesef,dersi geçemediniz.");
            }
            Console.ReadKey();--->Bu satırdaki ifade ile üst satırdaki işlemleri ekran tutuyoruz ancak herhangi bir tuşa basımında görevini tamamlamış olup program kapanıcaktır.
             
             
             


            ----Uygulama_3----


                Kullanıcıdan alınan pozitif tam sayının faktöriyelini hesaplayıp sonucu ekrana yazdırır.
            
            
            int gs,a,toplam=1; --->Bu satırda girilecek sayıyı,döngümüzde kullanmamız gereken değişkeni ve matematiksel işlemdeki kullanmamız gereken toplam adlı değişkeni burda tanımladık.
            Console.WriteLine("Faktöriyeli alınacak sayıyı(pozitif tam sayı örnek:1,2,3,..) giriniz."); --->Bu satırda kullanıcıdan sayı girmesini istiyeceğimiz mesajı ekrana yazdırdık.
            gs = Convert.ToInt32(Console.ReadLine());--->Bu satırda kullanıcının girmiş olduğu sayıyı gs adlı değişkene atamak.
            for (a =gs;1<=a ; a--) --->Bu satırda ise for adlı döngü kullanılmıştır.Bu döngü çalışma prensibi ise içeride belirli bir çalışma mantıgı vardır ilk kısımda değişkene değer atadık.İkinci kısımda ise şartımız var bu şart sağlandıysa süslü parantezdeki kod yapısı çalışır sonrada son kısımdaki ifade olur.Bu durum şart sağlanamamasına kadar döngü içi çalışır sonrada döngüden çıkılır. 
            { 
                toplam = a *toplam;
            }
            Console.WriteLine("{0} sayısının faktriyeli:{1}",gs,toplam);--->Bu satırda sonuç ekrana yazdırılmıştır.{} yapıları ise aldığımız değişken veya sonucu metinsel olarak yazdırmak için kullandık.Süslü parantez içindeki sayılar ise çift tırnak dışındaki sırası ile yazdığım değişkenleri indis sırasına göre yazdırmak içindir.
            Console.ReadKey();--->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.





            ----Uygulama_4-----


            Kullanıcı tarafından girilen ardışık sayı dizisinin başlangıç ve eleman sayısına göre toplamlarını bulan program.
            
            
            int sayi, sayac, toplam = 0;--->Bu satırda alınacak değerleri atamak ve matematiksel işlemler yapabilmek için tam sayılar sınıfında olan (int) türünden bir değişkenler tanımlanmıştır.
            Console.WriteLine("Lütfen ardışık sayılar dizisinde toplamındaki başlangıç sayınızı giriniz:");--->Kullanıcıdan başlangıç değerini girmesini isteyen mesaj satırıdır.
            sayi = Convert.ToInt16(Console.ReadLine()); Kullanıcıdan girilen sayıyı "sayi" adlı değişkene atanmıştır.
            Console.WriteLine("Kaç adet ardışık sayının toplamını istiyorsanız lütfen giriniz:");--->Eleman sayısını isteyen mesaj yazdırılmıştır bu satırda.
            sayac = Convert.ToInt16(Console.ReadLine());--->Kullanıcı tarafından girilen eleman sayısını "sayac" adlı değişkene atanmıştır.
            while (sayac>0)--->while döngü yapısında ise parantez içindeki şart sağlandığı her defasında süslü parantez içindeki kodlar çalışır sonrada döngüden çıkılır.
            {
                toplam = sayi + toplam;
                sayi++; --->sayi değişkenini bir arttırır.
                sayac--; --->sayac değişkenini bir azaltır.
            }
            Console.WriteLine("Sonuç:{0}",toplam);---->Döngü sonrası sonucu ekrana çift tırnak içerisindeki ifadeyi yazdıran kod satırıdır.
            Console.ReadKey(); --->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.


            -----Uygulama_4----

            Kullanıcı tarafından alınan iki sayının kullanıcı isteği doğrultusunda dört işlem yapan program.


            char islem; ---->Kullanıcının belirteceği işlem türünü tutacağımız değişken tanımlanmıştır.Tek karakterli işlem olacağı için char kullanılmıştır çünkü büyük projelerde gereksiz yere büyük alan kaplayan değişken türünden tanımlama yapmak programa olumsuz etkileri olucaktır(hız,alan vs.) gibi.
            int s1, s2, sonuc = 0; --->Kullanıcı tarafında girilecek sayıları atanacak değişkenler ve matematiksel işlem için gerekli değişken tanımlanmıştır.
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");--->Kullanıcıdan birinci sayını girilmesini isteyen metinsel mesajdır.
            s1 = Convert.ToInt16(Console.ReadLine());--->Kullanıcı tarafından girilen sayının s1 değişkenine atanmasıdır.
            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");--->Kullanıcıdan ikinci sayının girilmesini isteyen metinsel mesajdır.
            s2 = Convert.ToInt16(Console.ReadLine());--->Kullanıcı tarafından girilen sayının s2 değişkenine atanmasıdır.
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz.(Toplama işlemi için:+ Çıkarma işlemi için=- Çarpma işlemi için=* Bölme işlemi için=/ )");---->Bu satırda kullanıcak işlem türünün programa tanımlamasını isteyen metinsel mesajdır.
            islem = Convert.ToChar(Console.ReadLine());--->Kullanıcı tarafından girilen işlem tanımlama karakterini işlem değişkenine atar.
            switch (islem) --->Switch yapısında ise birden fazla ihtimali olan durumlarda kullanılır.Daha düzenli program yapısı ve hata payının minimum seviyeye indirmek için kullanılan kod yapısıdır.Case ifadeleri ise olası girdi ihtimallerine karşı yapılacak işlemlerdir.Eğer hiçbir case de tanımlı ifade değeri girilmemişse default değeri çalışır ve bu kod yapısından çıkılır.
            {
                case '+':
                        sonuc = s1 + s2;
                    Console.WriteLine("Sonuc:{0}", sonuc);
                    break;
                case '-':
                    sonuc = s1 - s2;
                    Console.WriteLine("Sonuc:{0}", sonuc);
                    break;
                case '*':
                    sonuc = s1 * s2;
                    Console.WriteLine("Sonuc:{0}", sonuc);
                    break;

                case '/':
                sonuc=s1 / s2;
                    Console.WriteLine("Sonuc:{0}", sonuc);
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    break;
                    

            }
            
            Console.ReadKey();--->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.
            


            ----Uygulama_5----


            Alttaki programda ise boolen hesaplamaların sonucu ekrana yazdıran programdır eğer alttaki konun mantığını anlaşılması için lütfen boolen cebri hakkında bilginiz olması tavsiye edilir.
            Bu kodlar sayesinde ise yazılımın matematikle olan ilişkisini belirli oranda algılamanıza yardımcı olucaktır.



            byte x = 10; //1010--- ikilik tabanda binary sisemdeki karşılığıdır.
            byte y = 15; //1111--- ikilik tabanda binary sisemdeki karşılığıdır.
            Console.WriteLine(true&true);//bu satırda boolen işleminin hesaplama sonucu yazdırılır.
            Console.WriteLine(true &false);//bu satırda boolen işleminin hesaplama sonucu yazdırılır.
            Console.WriteLine(true  | true);//bu satırda boolen işleminin hesaplama sonucu yazdırılır.
            Console.WriteLine(true | false);//bu satırda boolen işleminin hesaplama sonucu yazdırılır.
            Console.WriteLine("bitsel  ve işlemi="+(byte)(x&y));//bu satırda boolen işleminin byte tabanlı hesaplama sonucu yazdırılır.
            Console.WriteLine("bitsel  veya işlemi=" + (byte)(x | y));//bu satırda boolen işleminin byte tabanlı hesaplama sonucu yazdırılır.
            Console.WriteLine("bitsel  xor işlemi=" + (byte)(x ^ y));//bu satırda boolen işleminin byte tabanlı hesaplama sonucu yazdırılır.
            Console.WriteLine("bitsel  sola kaydırma işlemi=" + (byte)(x << 1));//bu satırda boolen işleminin byte tabanlı sağa bir defa kaydırmalı hesaplama sonucu yazdırılır.
            Console.WriteLine("bitsel  sağa kaydırma işlemi=" + (byte)(x >> 1));//bu satırda boolen işleminin byte tabanlı sola bir defa kaydırmalı hesaplama sonucu yazdırılır.
            Console.ReadKey();--->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.



            ----Uygulama_6----



            Bu programda ise dizilerle alakalı programdır.Dizileri mantıksal olarak matematikteki kümeler konusuyla aynı mantıkta çalışmaktadır.Burda belirlediğimiz türden değişkenleri belirli bir kapasitesine göre alıp gruplandırmaktadır.


            int i,kas,b;--->Bu satırdı programın mantıksal olarak gerekli olan değişkenler tanımlanmıştır.
            int[] dizi;---->Bu satırda integer(tam sayı) türünden "dizi" isimli bir dizi tanımlanmıştır.
            char durum;---->Kullanıcıya soracağımız soruya bağlı olarak oluşacak durumun atanacağı değişkendir.
            Console.WriteLine("Lütfen diziye kaçtane eleman girmek istiyorsanız giriniz:");--->Kullanıcıda kaç elemanlı dizi olacağını soruyoruz.
            kas = Convert.ToInt32(Console.ReadLine());--->Kullanıcıdan alınan dizi eleman sayısını bu değişkene belirliyoruz.
            dizi = new int[kas];--->Bu satırda dizi eleman sayısını "dizi" adlı değişkene atıyoruz
            for (i=0;i<(kas);i++) --->For döngüsünde ise alınan kullanıcı sayısını indis numaralarını belirterek "dizi" adlı değişkenimize atıyoruz.
            {

                dizi[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dizi elemanlarını görmek istermisiniz?(E,H)");--->Kullanıcıya girdiği değerleri görmesi için soruyoruz.
            durum = Convert.ToChar(Console.ReadLine());--->Kullanıcıdan alınan durum bildirimini "durum" adlı değişkene atıyoruz.
            if (durum == 'E' | durum=='e')--->Bu if(koşul yapısında) ise eğer durum değerleri "E veya(|) e" ise dizi elemanları alttaki döngüde indis numarası mantığıyla yazdırıyor eğer başka bir girdi alırsa else kısmı çalışır.
            {
                for (b = 0; b < (kas); b++)
                {
                    Console.WriteLine(dizi[b]);

                }
            }
            else {

                Console.WriteLine("İyi Günler!");
            }
            Console.ReadKey();--->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.


            ----Uygulama_7----


            Alttaki programda ise iki boyutlu dizi kullanarak kullanıcıdan tanımlı değişken kapasitesi sınırları içerisinde matris elemanları alan ve isteğe bağlı olarak yazdıran algoritmadır.Alttaki kod yapısını anlamadan önce lütfen matris konusu hakkında bilgi edinilmesi tavsiyemdir yoksa mantığını anlamanız zor olur.


            int[,] array;---->Burda "array" adında iki boyutlu integer(tam sayı) türünden bir dizi tanımladık.
            int satir, sutun,a,b,c,d;---->Burda kullanıcıdan alınacak matrisin satır ve sütun bilgilerini ve döngüler için kullanacağımız değişkenleri tanımladık. 
            char durum;--->Alınan matris değerlerinden sonraki aşama için kullanıcıdan alınacak durum bildirimini tutmak için tanımladığımız değişken.
            Console.WriteLine("Matrisinizin satır sayısını giriniz:");--->Kullanıcıdan satır sayısını istiyen bir metin yazdırdık ekrana.
            satir = Convert.ToInt32(Console.ReadLine());--->Alınan satır değerini "satir" adlı değişkene atadık.
            Console.WriteLine("Matrisinizin sütun sayısını giriniz:");--->Kullanıcıdan sütun sayısını istiyen bir metin yazdırdık ekrana.
            sutun = Convert.ToInt32(Console.ReadLine());--->Alınan sütun değerini "sutun" adlı değişkene atadık.
            array = new int[satir,sutun];--->Üstte tanımladığımız iki boyutlu dizinin satir ve sütun kapasitesini new kelime mantığıyla belirledik.
            for(a=0;a<satir;a++)--->Oluşacak dizi iki boyutlu dizi olacağı için içi içe kullanmamız gerekiyor.Çünkü iki eksende atamalar olcak (Örn:(0,0),(0,1),(1,0),(1,1)) gibi matris konumları indis numaralarına göre belirlenecek sırasıyla.
            {
                for (b=0;b<sutun;b++) {

                    array[a, b] = Convert.ToInt32(Console.ReadLine());
                }

                 }
            Console.WriteLine("Matris elemanlarını görmek ister misiniz(E-e/H-h)?");--->Kullanıcıdan görüntülemek ister misiniz diye durum bildirimi isteyen metin yazdırdık ekrana.
            durum = Convert.ToChar(Console.ReadLine());--->Kullanıcıdan gelen bildirimi "durum" değişkenine atadık.
            if (durum=='E'|durum=='e')--->"if" koşul ifadesiyle sorguladık parantez içindeki ifade doğru ise ekrana indis sırasına göre yazıcak girdiler sağlamıyorsa ELSE kısmı çalışacak.
            {

                for (c=0;c<satir;c++)--->İki boyutlu dizi olduğu için yazdırırkende yukarıdaki mantıkla aynı durum söz konusudur.
                {
                    for(d=0;d<sutun;d++){

                        Console.WriteLine("{0},{1} konumdaki eleman:{2}",c,d,array[c,d]);
                    }

                }
            }
            else
            {
                Console.WriteLine("İyi Günler!");
            }
            Console.ReadKey();--->Bu satırda ise kodumuz ekranda tutuluyor taki herhangi bir tuşa basılarak.


             */



        }
    }
}
