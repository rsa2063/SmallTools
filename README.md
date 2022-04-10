# SmallTools

### RenameFiles

> 1. 批量重命名文件
> 2. 打开时win10自动查找锁屏壁纸的缓存文件夹, 点击rename按钮会把图片提取到桌面上


### HashFiles

> hash files in the path and restore to the sqlite file

## shell
### subrename
* presubrename.sh(preview files that would be renamed)
* subrename.sh(rename files)

if you have
```
d:\a b\cd
    a1.mp4
    a2.mp4
    a3.mp4

d:\h i\jk
    x.ass
    y.ass
    z.ass
```

`./presubrename.sh d:/a\ b/cd d:/h\ i/jk` is recommend before next step

after `./subrename.sh d:/a\ b/cd d:/h\ i/jk`

you will get
```
d:\a b\cd
    a1.mp4
    a2.mp4
    a3.mp4

d:\h i\jk
    a1.srt
    a2.srt
    a3.srt
```
 