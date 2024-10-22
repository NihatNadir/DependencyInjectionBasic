# DependencyInjectionBasic

#### TeacherSınıfı

###### Özellikler:

- FirstName: string

- LastName: string

###### Metotlar:

- GetInfo(): Öğretmenin adını ve soyadını döndüren bir metot.

#### ClassRoom Sınıfı

###### Özellikler:

- Teacher: Ogretmen türünde bir nesne

###### Metotlar:

- GetTeacherInfo(): Öğretmenin bilgilerini döndüren bir metot. Teacher içerisindeki GetInfo()'yu çağırması yeterli.

#### Görev:
- Teacher ve Classroom sınıflarını yazın.
- ClassRoom sınıfının yapıcısına (constructor) Teacher sınıfının bir örneğini (instance) parametre olarak geçin. (Constructor Injection)
- Her iki sınıfın metotlarını kullanarak bir Classroom nesnesi oluşturun ve öğretmenin bilgilerini ekrana yazdırın.

###### NOT: Dependency Injection, bir sınıfın ihtiyaç duyduğu bağımlılıkların dışarıdan verilmesi anlamına gelir. Bu, sınıflar arasındaki bağımlılıkları azaltarak daha esnek bir yapı sağlar.
###### EK : Ogretmen sınıfı için bir Base Interface oluşturmayı unutmayın. IOgretmen
