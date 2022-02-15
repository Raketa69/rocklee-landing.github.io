@charset "UTF-8";
body {
  margin: 0;
  padding: 0;
  background-color: #000000;
}

/* Обычный */
@font-face {
  font-family: "PT Sans";
  src: url(../fonts/ptsans/PTS55F.ttf);
}
@font-face {
  font-family: "Playfair Display";
  src: url(../fonts/Playfair_Display/static/PlayfairDisplay-Black.ttf);
}
/* Обычный */
@font-face {
  font-family: "Post No Bills";
  src: url(../fonts/Post-No-Bills-Jaffna-SemiBold/postnobillsjaffna/PostNoBillsJaffna-Medium.ttf);
}
a:link {
  color: #969696;
  text-decoration: none;
}

a:active {
  color: #969696;
  text-decoration: none;
}

a:hover {
  color: #969696;
  text-decoration: underline;
}

a:visited {
  color: #969696;
}

.top {
  background-color: black;
  margin: 0;
  padding: 0;
}
.top .top-1 {
  height: 44px;
  color: #969696;
  font-family: "PT Sans";
  font-style: normal;
  font-weight: normal;
  font-size: 14px;
  line-height: 14px;
}
.top .top-1 .top-1-info {
  padding-left: 20%;
  padding-top: 14px;
  position: absolute;
}
.top .top-1 .top-1-login {
  padding-top: 14px;
  padding-left: 70%;
  position: absolute;
}
.top .top-2 {
  height: 80px;
  background-color: #0F0F0F;
  color: white;
  padding: 0;
  font-family: "PT Sans";
}
.top .top-2 .table-bar {
  padding-left: 20%;
}
.top .top-2 .top-2-ROCKLEE {
  font-family: "Post No Bills";
  color: white;
  font-size: 36px;
  width: 136px;
}
.top .top-2 .button-top {
  width: 136px;
  text-align: center;
  height: 70px;
  vertical-align: middle;
  font-family: "Post No Bills";
  display: table-cell;
}
.top .top-2 button {
  border: none;
  background-color: #0F0F0F;
  color: #969696;
  font-size: 14px;
}
.top .top-2 button:hover {
  background-color: #1F1F1F;
  color: white;
  border: none;
}
.top .top-2 .button-top-small {
  image-rendering: -moz-crisp-edges;
  /* Firefox */
  -ms-interpolation-mode: nearest-neighbor;
  /* IE */
  image-rendering: crisp-edges;
  /* Стандартное свойство */
  position: center;
  height: 70px;
  width: 70px;
}
.top .top-2 table {
  border-spacing: 0;
}
.top .top-2 .icon {
  margin-top: 25px;
}
.top .top-2 .top-space {
  width: 400px;
}

.logo-div {
  padding-top: 160px;
  height: 810px;
  width: 1920px;
  background-image: url(../img/background.png);
  background-repeat: no-repeat;
  background-size: 100%;
  margin: 0 auto;
  display: block;
  color: white;
}
.logo-div .logo-quard {
  top: 160px;
  height: 320px;
  width: 320px;
  border: 4px solid #FFFFFF;
  margin-right: auto;
  margin-left: auto;
  font-family: "Post No Bills";
  text-align: center;
  font-size: 50px;
}
.logo-div .logo-text {
  margin: auto;
  margin-top: 93px;
  text-decoration: underline;
}
.logo-div .logo-text-city {
  font-size: 34px;
}
.logo-div .logo-text2 {
  margin-top: 80px;
  text-align: center;
  text-transform: uppercase;
  font-size: 20px;
  line-height: 150%;
}

.horizontalSeparator {
  position: center;
  width: 120px;
  height: 0px;
  top: 140px;
  border: 1px solid #BFDCE8;
  margin-top: 50px;
}

.collection-box {
  height: 730px;
  width: 100%;
  margin: 0 auto;
  display: block;
  margin-top: -160px;
}
.collection-box .box1 {
  position: absolute;
  height: 730px;
  width: 50%;
  margin: 0;
  font-family: "Playfair Display";
  color: white;
  font-size: 36px;
  line-height: 42px;
  text-align: center;
  text-transform: uppercase;
}
.collection-box .box1 .box1-text {
  margin-top: 93px;
}
.collection-box .box1 .box1-table {
  color: white;
  margin-top: 50px;
  margin-left: auto;
  margin-right: auto;
}
.collection-box .box1 .box1-table .box1-table-card {
  height: 325px;
  width: 260px;
  background: #191B1C;
  border: white;
  color: white;
  margin-left: 25px;
  margin-right: 25px;
}
.collection-box .box1 .box1-table-link {
  color: white;
  width: 940px;
  font-family: "Playfair Display";
  margin-top: 25px;
  font-size: 18px;
  line-height: 21px;
  margin-left: auto;
  margin-right: auto;
}
.collection-box .box2 {
  position: absolute;
  left: 50%;
  height: 730px;
  width: 50%;
  background-image: url(../img/box2-img.png);
  background-repeat: no-repeat;
  margin: 0 auto;
  display: block;
  color: white;
  background-size: 100%;
}
.collection-box .box2 .box2-text {
  font-family: "Playfair Display";
  font-size: 36px;
  line-height: 42px;
  text-align: center;
  text-transform: uppercase;
  color: #FFFFFF;
  margin-top: 484px;
}

.button-new_collection {
  width: 150px;
  display: block;
  height: 50px;
  font-family: "PT Sans";
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  line-height: 23px;
  letter-spacing: 0.1em;
  text-transform: uppercase;
  margin-left: auto;
  margin-right: auto;
  margin-top: 50px;
  background: transparent;
  color: #FFFFFF;
  border: 1px solid #BFDCE8;
}

.collection-box2 {
  height: 600px;
  width: 100%;
  margin: 0 auto;
  display: block;
  margin-top: -320 px;
}
.collection-box2 .box1 {
  position: absolute;
  height: 600px;
  width: 40%;
  margin: 0;
  font-family: "Playfair Display";
  background-image: url(../img/box2-1-img.png);
  background-repeat: no-repeat;
}
.collection-box2 .box2 {
  color: #FFFFFF;
  text-align: center;
  position: absolute;
  height: 600px;
  width: 60%;
  margin-left: 40%;
  font-family: "Playfair Display";
}
.collection-box2 .box2 .box2-text1 {
  font-size: 36px;
  width: 400px;
  line-height: 42px;
  text-transform: uppercase;
  margin-top: 100px;
  margin-left: auto;
  margin-right: auto;
}
.collection-box2 .box2 .box2-text2 {
  width: 471px;
  height: 173px;
  font-family: "PT Sans";
  font-style: normal;
  font-weight: normal;
  font-size: 14px;
  line-height: 150%;
  /* or 21px */
  text-align: center;
  margin-left: auto;
  margin-right: auto;
  margin-top: 40px;
}
.collection-box2 .box2 .button-new_collection {
  width: 300px;
}

.collection-box3 {
  width: 100%;
  height: 1289px;
  border: 1px solid red;
  color: #FFFFFF;
}
.collection-box3 .box3-text1 {
  font-family: "Playfair Display";
  font-size: 36px;
  line-height: 42px;
  text-align: center;
  text-transform: uppercase;
  margin-top: 120px;
}
.collection-box3 .box3-table {
  font-size: 18px;
  line-height: 21px;
  color: white;
  padding-left: 23px;
  padding-right: 11.5px;
  position: center;
  margin-top: 81px;
  margin-right: auto;
  margin-left: auto;
}
.collection-box3 .box3-table-img {
  background: #191B1C;
  background-image: url(../img/clock-img.png);
  background-repeat: no-repeat;
  background-position: center;
  height: 325px;
  width: 260px;
  margin-left: 13px;
  margin-right: 13px;
}
.collection-box3 .box3-table-text {
  margin-top: 25px;
  color: #FFFFFF;
  margin-left: 13px;
  margin-right: 13px;
}

.box4 {
  border: 1px solid greenyellow;
  height: 362px;
  width: 100%;
  color: white;
  background: #0F0F0F;
}
.box4 .box4-text1 {
  font-family: "Playfair Display";
  font-size: 36px;
  line-height: 42px;
  text-align: center;
  text-transform: uppercase;
  margin-top: 120px;
}
.box4 .box4-table-brand {
  position: center;
  margin-left: auto;
  margin-right: auto;
}

.box5 {
  border: 1px solid blueviolet;
  height: 400px;
  width: 100%;
  color: white;
  background-image: url(../img/box5-background.png);
  background-repeat: no-repeat;
  background-position: center;
}
.box5 .box5-table {
  margin-top: 80px;
  position: center;
  margin-left: auto;
  margin-right: auto;
}
.box5 .box5-table .box5-table-tr1 {
  font-family: "Playfair Display";
  font-size: 24px;
  line-height: 28px;
  text-transform: uppercase;
}
.box5 .box5-table .box5-table-tr2 {
  font-family: "PT Sans";
  font-style: normal;
  font-weight: normal;
  font-size: 14px;
  line-height: 150%;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td1 {
  height: 147px;
  width: 350px;
  margin-top: 40px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 {
  font-style: normal;
  font-weight: normal;
  font-size: 14px;
  line-height: 150%;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 button {
  border: none;
  font-family: "PT Sans";
  color: #FFFFFF;
  background: #0F0F0F;
  align-items: center;
  height: 41px;
  margin: 20px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 .button-clock {
  width: 98px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 .button-bracer {
  width: 98px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 .button-belt {
  width: 79px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 .button-jewelry {
  width: 164px;
}
.box5 .box5-table .box5-table-tr2 .box5-table-tr2-td2 .button-cufflinks {
  width: 91px;
}

/*# sourceMappingURL=style.cs.map */
