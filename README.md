# 📚 Kütüphane Yönetim Sistemi

Bu proje, bir **ASP.NET Core MVC** uygulamasıdır ve kütüphanelerin kitap ve yazar işlemlerini yönetmesine olanak sağlar. Kullanıcı dostu arayüzü ve esnek yapısı ile kitap ve yazar bilgilerini kolayca ekleyebilir, düzenleyebilir, görüntüleyebilir ve silebilirsiniz.

---

## 🚀 Proje Özellikleri

- **Kitap Yönetimi:**
  - Kitap ekleme, düzenleme, silme ve listeleme.
  - Kitap detaylarını görüntüleme.
- **Yazar Yönetimi:**
  - Yazar bilgilerini ekleme, düzenleme ve silme.
  - Yazarların detaylarını ve doğum tarihlerini görüntüleme.
- **Modern Arayüz:**
  - Responsive tasarım için **Bootstrap 5** kullanıldı.
  - Sabit footer ile profesyonel bir görünüm.
- **Ana Sayfa ve Hakkında Bölümü:**
  - Kullanıcıyı yönlendiren bir ana sayfa.
  - Proje hakkında bilgi içeren bir "Hakkında" sayfası.
- **Nesne Yönelimli Tasarım (OOP):**
  - Model-View-Controller (MVC) prensipleriyle yapılandırılmıştır.

---

## 🛠️ Kullanılan Teknolojiler

- **Dil:** C#, HTML, CSS
- **Framework:** ASP.NET Core MVC
- **CSS Framework:** Bootstrap 5
- **Araçlar:** Visual Studio

---

## 📂 Proje Mimarisi

- **Controllers:** 
  - İş mantığı ve yönlendirmeler. Örneğin: `BookController`, `AuthorController`.
- **Models:** 
  - Veritabanı ve ViewModel tanımları. Örneğin: `Book`, `Author`.
- **Views:** 
  - Kullanıcıya sunulan arayüzler. Örneğin: `Add`, `Details`, `Delete`.
- **Shared:** 
  - Ortak kullanılan `Layout` ve `Partial View` dosyaları.
- **wwwroot:** 
  - Statik dosyalar (CSS, JS, görseller).

---

## 📜 Proje Gereksinimleri

### **Model Tanımları**

#### **Book Modeli**
| Alan Adı         | Tür            | Açıklama                                  |
|-------------------|----------------|------------------------------------------|
| `Id`             | `int`          | Benzersiz kitap kimliği.                 |
| `Title`          | `string`       | Kitap adı.                               |
| `AuthorId`       | `int`          | Yazar kimliği (Author modeli ile bağlı). |
| `Genre`          | `string`       | Kitap türü.                              |
| `PublishDate`    | `DateTime`     | Yayın tarihi.                            |
| `ISBN`           | `string`       | ISBN numarası.                           |
| `CopiesAvailable`| `int`          | Mevcut kopya sayısı.                     |

#### **Author Modeli**
| Alan Adı         | Tür            | Açıklama                                  |
|-------------------|----------------|------------------------------------------|
| `Id`             | `int`          | Benzersiz yazar kimliği.                 |
| `FirstName`      | `string`       | Yazar adı.                               |
| `LastName`       | `string`       | Yazar soyadı.                            |
| `DateOfBirth`    | `DateTime`     | Yazarın doğum tarihi.                    |

---

## 📜 Kullanım

### **Projenin Çalıştırılması**
 
   ```bash
   git clone https://github.com/hrpbedirhan/LibraryManagementSystem
   cd LibraryManagementSystem
   dotnet run

