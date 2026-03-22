# Localyssation-NumAni

[![Version](https://thunderstore-badges.foreverjlong.workers.dev/Jeneration_Technology/LocalyssationJP/version)](https://thunderstore.io/c/atlyss/p/Jeneration_Technology/LocalyssationJP/)
[![Downloads](https://thunderstore-badges.foreverjlong.workers.dev/Jeneration_Technology/LocalyssationJP/downloads)](https://thunderstore.io/c/atlyss/p/Jeneration_Technology/LocalyssationJP/)

[ATLYSS](https://store.steampowered.com/app/2768430/ATLYSS/) の多言語翻訳を補助するMODです。機能は完全でない場合があります。

## 使い方

1. 以下をインストールしてください。
    * [BepInEx](https://thunderstore.io/c/atlyss/p/BepInEx/BepInExPack/) 5.4
    * [EasySettings](https://thunderstore.io/c/atlyss/p/Nessie/EasySettings/) 1.1.8 以降
    * 最新の [Localyssation](https://github.com/numanicloud/Localyssation/releases)
4. BepInEx の `plugins` フォルダ内のどこかに、📜言語パッチを配置してください。
    - **Localyssation だけでは翻訳は完結しませんので、ご注意ください。**
    - 日本語版の📜言語パッチは、[ガーティア](https://gatia.kage-tora.com/index.html) 様が [すみっこモノづくり](https://gatia.kage-tora.com/atlyss_jp.html) にて配布してくださっています。

## 提供されている機能

1. ゲーム内 settings の mods タブに、Localyssation オプションを追加します。ここで言語とフォントを変更できます。(💡1)(💡2)
2. チャットボックス内のテキストと、頭上に出るチャット文字に Unicode 文字が使用されます。(💡3)
3. BepInEx plugins フォルダ内にある 📜**言語パッチ** をロードし、翻訳に使用します。
4. 翻訳作業をしていただける方への☕支援機能
5. 他の MOD が表示するテキストであっても、その MOD が翻訳キーを提供しているのなら翻訳ができます。

### 📜言語パッチとは

言語パッチとは以下で構成されるフォルダです:
* `localyssationLanguage.json`: 言語に関する情報
* `strings.yml`: 翻訳キーとテキストのペアの羅列

### ☕翻訳支援機能

* 作業の取り掛かりのために、デフォルトの `strings.yml` を出力します。
* アイテムやクエストの詳細情報を MOD フォルダ内に `.md` ファイルとして出力します。
  * `ScriptableItem.md`: アイテムの翻訳キー、アイコン、名前
  * `ScriptableQuest.md`: クエストの翻訳キー、依頼者、タイプ(繰り返し可能か)、サブタイプ(メイン、クラス専用など)、名前
* 翻訳されていないテキストをゲーム内で翻訳キーで表示する機能。
* ゲーム起動中に言語パッチを再ロードする機能。
* 2つの `strings.yml` を比較して、差分をチェックできる [Diff tool](https://github.com/numanicloud/Localyssation/releases/tag/v2.4.0-12026.a3) を提供します。ゲーム本体の新バージョンがリリースされた際に利用できます。

### こんなときは？

* (💡1)ゲーム内設定に mods タブが表示されない場合、 EasySettings が導入されているか再確認してください。
* (💡2)言語パッチがフォントを提供しない場合、 unifont が使用されます。
* (💡3)チャット テキストのフォントが正常に表示されるためには、言語パッチが適切なフォントを提供する必要があります。
* バグを見つけた場合や、翻訳できないテキストを見つけた場合、GitHub issue を使って報告いただくことができます。

## 翻訳者の方へ・MOD開発者の方へ

ぜひ、独自の言語パッチを制作してください。翻訳不能な箇所を見つけた場合、GitHub issueなどを通じてご連絡ください。

- MOD のインストール方法や言語パッチの作り方に関しては [wiki](https://github.com/sallys-workshop/Localyssation/wiki/To-create-a-game-translation) をご覧ください。
- 言語パッチに [Font Bundles](https://github.com/sallys-workshop/Localyssation/wiki/Font-Bundle-aka.-Why-characters-don't-get-displayed-(2.0)) を同梱することもご検討ください。その際、法的問題を避けるためにも **商用利用可能かつ、埋め込み可能** なフォントを選択するようお願い致します。
- Localyssation 2.0.0 以降は他 MOD が提供する翻訳キーに対する翻訳をサポートしています。 [wiki page](https://github.com/sallys-workshop/Localyssation/wiki/To-create-a-mod-translation) をご覧ください。
- Localyssation には画像内のテキストを翻訳する機能がありません。テクスチャ自体の置き換えができる他の方法をご検討ください。

## Credit

1. この MOD は [TheMysticSword](https://github.com/TheMysticSword/Localyssation) によって開発されました。
2. チーム **Sally's Workshop**(莎莉小店) の [TowardtheStars](https://github.com/TowardtheStars) が、CHS翻訳の一環としてメンテナンスを引き継ぎました。
3. この fork は日本人の [numanicloud](https://github.com/numanicloud)　がメンテナンスを引き継いでいます。
