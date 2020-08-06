# Repository untuk Game Jam IGSI
By: Garlic Studio

Members:
- [Matthew Sutanto](github.com/mtstnt)
- [Winson E. Sutanto](github.com/kaburov38)
-
-
-
-

## Setting awal project:
1. Download [git](https://git-scm.com/downloads) dan buat account Github. Terus buat project baru di Unity, pakai preset 3D (karena project ini skrg 3D).
2. Pastikan git sudah di set di PATH. Cara cek: Buka cmd, ketik
	<code>git --version</code>

	kalau keluar versi gitnya, berarti sudah oke.
3. Klik tombol Code di atas atas repository ini, copy link yang di clone with HTTPS.
4. Kembali ke cmd, masuk ke folder tempat menyimpan project Unity, kemudian ketik
	<code>git clone link-tadi</code>

	Link tadi diganti link yang dicopy tdi ya.
5.  Nanti di folder itu akan muncul folder baru, isinya adalah isi repository ini. Cut semua dan paste di folder yang tempat tadi buat git
6. Sip sudah selesai. Project bisa digunakan.

## Tiap kali melanjutkan:
1. Ketik ini di cmd: <code>git pull origin master</code>
Ini untuk update kalo ada yang baru di master. (Sementara ini kita pakai master, nanti pindah branch)
2. Lanjutkan projectnya

## Untuk push update
1. <code>git add .</code> -> Menambahkan file2 yang udah berubah di folder itu ke stage
2. <code>git commit -m "Deskripsi commitnya"</code> -> Deskripsi commitnya tulis apa yg berubah. Commit ngesave perubahan ke **LOCAL** git repository. Jadi di komputermu tok
3. <code>git push origin nama-branch</code> -> Nama branchnya yang mau di push, misal master. Push mengupload commitmu ke **REMOTE** repository, yaitu di Github ini.
