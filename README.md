# Yerel İşletmeler için Sosyal Yemek Platformu

## Projenin Konusu
Yerel işletmecilerin (restoranlar, kafeler, pastaneler vb.) ürün ve hizmetlerini dijital ortama taşıyabilecekleri, sipariş alabilecekleri ve kampanyalar düzenleyebilecekleri bir sosyal ticaret ağı oluşturmayı hedefliyoruz. Bu platform, işletmecilere dijitalleşme fırsatı sunarken, kullanıcılar için hızlı, güvenilir ve sosyal bir alışveriş deneyimi sağlar.

Temel Özellikler:
	1.	Yerel Ekonomiye Destek: İşletmeciler kendi müşteri tabanlarını oluşturabilir ve yerel tüketici kitlesine daha etkili ulaşabilir.
	2.	Güvenilir Sosyal Ticaret Ağı: Kullanıcılar için hızlı ve şeffaf bir alışveriş deneyimi sağlanır.
 	3.	Dijitalleşme Fırsatı: Küçük işletmeler, dijital ortama geçiş yaparak daha geniş bir kitleye hitap edebilir.
	4.	Topluluk Bağları: İşletmeler arasında işbirliği ve dayanışma ortamı oluşur.

## Projenin Hedefleri
- Güvenilir bir sosyal ticaret ağı oluşturmak.
- Yerel ekonomiye katkı sağlamak.
- Küçük işletmelerin dijitalleşme sürecine destek olmak.
- Kullanıcılar için hızlı ve şeffaf bir alışveriş deneyimi sunmak.

## Kullanılacak Teknolojiler
- **Frontend:** React.js / Angular (Bootstrap ile desteklenmiş)
- **Backend:** .NET Core Web API
- **Veritabanı:** MS SQL
- **Authentication:** Token tabanlı kimlik doğrulama
- **Diğer Araçlar:** Entity Framework Core, RESTful API

## Projenin İçeriği

### Senaryo 1: Yönetici Paneli ve Onay Süreci
Latif Bey, yeni bir kafe işletmesini sisteme kaydetmek istiyor. Üyelik başvurusunda işletmesinin detaylarını (örneğin işletme adı, kategori, iletişim bilgileri) dolduruyor. Platform sahibi, Latif Bey’in bilgilerini inceliyor ve üyeliğini onaylıyor. Onaylanmayan işletmeciler sisteme erişemiyor.

Kabul Kriterleri:
	•	Yönetici paneli işletmecileri onaylama/dışlama özelliklerine sahip olmalı.
	•	Onaysız işletmeciler sisteme giriş yapamamalı.
	•	Yönetici panelinde raporlama ve kampanya denetimi yapılabilmeli.

### Senaryo 2: Yerel İşletmelerin Dijitalleşmesi
Nur Hanım, bir butik restoran işletmecisi olarak, yemek menüsünü dijital ortama taşımak istiyor. Platforma üye olduktan ve onay aldıktan sonra restoranının menüsünü sisteme ekliyor. “Günlük Taze Lahmacun Menüsü” ve “Mevsimlik Tatlılar” gibi ürünlerini yalnızca Nur Hanım listeleyip düzenleyebiliyor. Kullanıcılar, menüyü inceleyip sipariş verebiliyor ancak ürün ekleme veya düzenleme işlemi yapamıyor.


#### Kabul Kriterleri:
- İşletmeciler ürünlerini listeleyebilmeli ve düzenleyebilmeli.
- Kullanıcılar, ürünleri inceleyip sipariş verebilmeli.
- Kullanıcılar ürün ekleme ve düzenleme işlemi yapamamalı.
- İşletmeciler kampanya ve indirim özelliklerini menülerine ekleyebilmeli.

### Senaryo 3: Kampanyalar ve İlgi Çekici Paylaşımlar
Kemal Bey, kafe işletmesi için kahvaltı menüsünü tanıtmak istiyor. Platformda "Hafta Sonu Kahvaltı Şöleni %20 İndirimli" şeklinde bir kampanya başlatıyor. Bu kampanya, platformun ana sayfasında yer alarak kullanıcıların ilgisini çekiyor. İrem Hanım, bu kampanyayı görüp yorum yapıyor ve çalışanları için toplu bir kahvaltı siparişi veriyor. Sipariş sonrası, menüyü beğendiğini belirterek Kemal Bey’in profilinde olumlu bir referans bırakıyor.

#### Kabul Kriterleri:
- İşletmeciler kampanya oluşturma, düzenleme ve silme işlemleri yapabilmeli.
- Kampanyalar görsel, açıklama ve indirim detaylarıyla ana sayfada gösterilmeli.
- Kullanıcılar kampanyalara yorum yapabilmeli ve sipariş oluşturabilmeli.

### Senaryo 4: Mesajlaşma ve Teklif Yönetimi
Ayşe Hanım, restoranında bir etkinlik düzenlemek için taze ekmek siparişi vermek istiyor. Platform üzerinden Ali Bey’in fırınına mesaj göndererek bir teklif talebinde bulunuyor. Ali Bey, gelen teklif talebini listesinde görüntüleyip Ayşe Hanım’a bir fiyat sunuyor. Anlaşma sağlandıktan sonra sipariş detayları tamamlanıyor.

#### Kabul Kriterleri:
- Kullanıcılar işletmelere özel mesaj gönderebilmeli.
- İşletmeciler gelen mesajları ve teklif taleplerini listeleyip yönetebilmeli.
- Sipariş tamamlandığında kullanıcılar geri bildirim bırakabilmeli.

### Senaryo 5: Sosyal Ağ ve Trendler
Ayşe Hanım, platformun ana sayfasında "Trendler" bölümünü incelerken en çok sipariş alan kafe işletmesini görüyor. İşletmenin popüler kahvaltı menüsünü inceleyip sipariş veriyor. Sipariş sonrası geri bildirim bırakıyor ve işletmeyi takip ediyor.

#### Kabul Kriterleri:
- Ana sayfada popüler işletme ve kampanyalar sıralanabilmeli.
- Kullanıcılar işletmeleri takip edebilmeli.
- Kullanıcılar takip ettikleri işletmelerin kampanyalarını ana sayfalarında görebilmeli.

## Ek Özellikler

### Raporlama
	-	En çok sipariş verilen ürünler, en popüler işletmeler ve kullanıcıların arama davranışları analiz edilir.
	-	İşletmeler, raporlardan faydalanarak ürün ve hizmetlerini geliştirebilir.
	-	Sistem sahibi, kullanıcı davranışlarını analiz ederek platform genelindeki trendleri gözlemleyebilir.

#### Kabul Kriterleri:
- Platformda işletme performansı için raporlama yapılabilmeli.
- İşletmeler, raporlardan faydalanarak ürün ve hizmetlerini geliştirebilmeli.
- Sistem sahibi, kullanıcı davranışlarını analiz ederek platform genelindeki trendleri gözlemleyebilmeli.

## Proje Faydaları
1. **Yerel Ekonomiye Destek**: İşletmeciler kendi müşteri tabanlarını oluşturabilir ve yerel tüketici kitlesine daha etkili ulaşabilir.
2. **Dijitalleşme Fırsatı**: Küçük işletmeler, dijital ortama geçiş yaparak daha geniş bir kitleye hitap edebilir.
3. **Kullanıcı Deneyimi**: Yerel lezzetlere ulaşmak isteyen kullanıcılar için güvenilir ve hızlı bir sipariş sistemi sunar.
4. **Topluluk Bağları**: Yerel işletmeler arasında işbirliği ve dayanışma ortamı oluşur.
5. **Güven ve Şeffaflık**: Geri bildirim ve puanlama sistemleri sayesinde kullanıcılar güvenle alışveriş yapabilir.

