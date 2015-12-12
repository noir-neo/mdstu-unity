# MD勉強会 151212

Unity 3Dゲーム byねおりん


## プロジェクトを作る

1. Unity を起動
2. New
3. プロジェクトの名前と保存場所、3Dを選択
4. Create project

![](http://i.imgur.com/w1niZdS.png)
![](http://i.imgur.com/6xZR7w3.png)


## シーンを作る

### おまけ: Git で管理する

#### Unity プロジェクト設定

Edit > Project Settings > Editor

* Version Control の Mode を Visible Meta Files に変更する
* Asset Serialization の Mode を Force Text

![](http://i.imgur.com/r8m2OMb.png)
![](http://i.imgur.com/Y8QR0GV.png)


#### .gitignore

https://github.com/github/gitignore/blob/master/Unity.gitignore


### おもむろに保存

`Assets/Scenes/Main.unity`

![](http://i.imgur.com/RYfuJoP.png)



### とりあえず再生

天地創造2日目まで Done


### 地面を作る

3日目

GameObject > 3D Object > Terrain
GameObject > 3D Object > Cube


![](http://i.imgur.com/uekrnf7.png)


## モデルを放り込む

1. `Assets/Resources/Models` を作る
2. Project ビューに fbx をドラッグアンドドロップ
3. Hierarchy ビューもしくは Scene ビューにドラッグアンドドロップ

![](http://i.imgur.com/0js6W8o.png)


## 物理を設定する

1. Hierarchy で plane を選択
2. Inspector から Add Component
3. Physics > Rigidbody
4. Physics > Box Collider

再生すると落ちて、地面をすり抜けなければ :ok_woman:

![](http://i.imgur.com/Tq3gIEv.jpg)
![](http://i.imgur.com/NVRkxXQ.jpg)
![](http://i.imgur.com/oV5Pgzm.png)

余裕のある人はいい感じに羽と胴体それぞれにコライダーをつけましょう(胴体には Capsule Collider 使うといいかも)
![](http://i.imgur.com/E7XJWvo.png)


## Standard Assets で飛ばす！

便利すぎてちょっとしたものならこれで作れてしまう…

### Vehicles/Aircraft

1. Assets > Import Package > Vehicles
2. Import
3. `Assets/Standard Assets/Vevhicles/Aircraft/Scripts` から
`AeroplaneController`
`AeroplaneUserControl4Axis`
を Plane にドラッグアンドドロップ


![](http://i.imgur.com/asAOv15.png)
![](http://i.imgur.com/FJz29xX.png)

再生すると WASD とマウスで操作できるように！！

### Cameras

1. Assets > Import Package > Cameras
2. Import
3. Hierarchy から Main Camera を Delete
4. `Assets/Standard Assets/Cameras/Prefabs` から
`MultipurposeCameraRig`
を Hierarchy にドラッグアンドドロップ
5. Hierarchy で `MultipurposeCameraRig` を選択
6. Inspector 内 Target に Hierarchy の Plane をドラッグアンドドロップ

![](http://i.imgur.com/aelEWN0.png)
![](http://i.imgur.com/XTvgcdf.png)

近すぎるけど、カメラが付いて行くようになる

## スクリプト書いてみる(時間があれば)


