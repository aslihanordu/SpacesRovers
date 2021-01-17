# SpaceRovers

NASA tarafından Mars'taki bir platoya bir robotik gezici ekibi inecek. Dikdörtgen olan bu plato, gezgini, gemideki kameralarının Dünya'ya geri göndermek için çevredeki arazinin tam bir görüntüsünü alabilmesi için geziciler tarafından yönlendirilmelidir. Bir gezicinin konumu ve konumu, x ve y koordinatlarının bir kombinasyonu ve dört ana pusula noktasından birini temsil eden bir harf ile temsil edilir. Plato, navigasyonu kolaylaştırmak için bir ızgaraya bölünmüştür.  Bir gezgini kontrol etmek için NASA basit bir harf dizisi gönderir. Olası harfler "L", "R" ve "M" dir. 'L' ve 'R', gezginin mevcut noktasından hareket etmeden sırasıyla 90 derece sola veya sağa dönmesini sağlar. 'M' bir ızgara noktası ileri gitmek ve aynı istikameti korumak anlamına gelir. (X, y) 'nin doğrudan kuzeyindeki karenin (x, y + 1) olduğunu varsayalım.

## Giriş

İlk girdi satırı platonun üst-sağ koordinatlarıdır, sol alt koordinatların 0,0 olduğu varsayılır. Girişin geri kalanı, konuşlandırılan gezicilerle ilgili bilgilerdir. Her gezicinin iki satır girişi vardır. İlk satır, gezicinin konumunu verir ve ikinci satır, geziciye platoyu nasıl keşfedeceğini söyleyen bir dizi talimattır. Konum, x ve y koordinatlarına ve gezicinin yönüne karşılık gelen iki tam sayı ve boşluklarla ayrılmış bir harften oluşur. Her gezici sırayla bitirilecektir, bu da ikinci gezicinin ilki hareketini bitirene kadar hareket etmeye başlamayacağı anlamına gelir.

## Çıktı:
Her gezicinin çıktısında, koordinatları ve yönü olmalıdır.

## Test Girişi
```
5 5
1 2 N
LMLMLMLMM

3 3 E
MMRMMRMRRM
```
## Beklenen çıktı
```
1 3 N
5 1 E
