# UnityChan_Maze
Maze game by Unicy-Chan
Unityちゃんの迷路ゲーム

---------------

## STEP 01 準備

* プロジェクト新規作成
* Unityちゃん Package のインポート
* Scene保存

## STEP 02 ステージ

* Plane作成
* Material貼り付け
* Unityちゃんをステージへ（unitychan_dynamic_locomotion)
* Package に入っている Main Cameraへ切り替え

## STEP 03 ゴールの処理

* ゴールを表現するダミーのSphere作成、Colliderアタッチ、OnTriggerオン
* Goal.cs 作成＆アタッチ
* UnityちゃんのAnimatorControllerを編集
* UnityちゃんのスクリプトにOnGoalメソッドを追加
* OnGoal メソッドに this.enable = false; を追加し、ゴール後は動かないように

## STEP 04 落ちたらゲームオーバー
* Unityちゃんのスクリプトにゲームオーバーの処理を追加

