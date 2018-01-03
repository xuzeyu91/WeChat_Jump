# 教你用 .Net和Android 来玩微信跳一跳
## 游戏模式

> 2017 年 12 月 28 日下午，微信发布了 6.6.1 版本，加入了「小游戏」功能，并提供了官方 DEMO「跳一跳」。这是一个 2.5D 插画风格的益智游戏，玩家可以通过按压屏幕时间的长短来控制这个「小人」跳跃的距离。分数越高，那么在好友排行榜更加靠前。通过 .Net脚本自动运行，让你轻松霸榜。


可能刚开始上手的时候，因为时间距离之间的关系把握不恰当，只能跳出几个就掉到了台子下面。如果能利用图像识别精确测量出起始和目标点之间测距离，就可以估计按压的时间来精确跳跃。
![](https://github.com/xuzeyu91/WeChat_Jump/blob/master/jump.gif)
## 原理说明

1. 将手机点击到《跳一跳》小程序界面

2. 用 ADB 工具获取当前手机截图，并用 ADB 将截图 通过socket传输到PC端，如果不了解socket通讯的可以查看我的另外个项目(https://github.com/xuzeyu91/AndroidScreenCap)

3. 计算按压时间
通过在Winform程序里面点击2个间隔的距离来判断按压时间。

4. 用 ADB 工具点击屏幕蓄力一跳
```shell
adb shell input swipe x y x y time(ms)
```

## 使用教程

安装项目中Android的程序。然后在WinForm中点击初始化进行端口转发后，创建Socket连接，即可开始进行跳一跳。


<br>
QQ 交流

- 556433450
微信群：![](https://github.com/xuzeyu91/WeChat_Jump/blob/master/jump.gif)