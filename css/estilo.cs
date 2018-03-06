:root {
  --sizem: 100%; }

.gridx {
  padding: 20px; }

.m-recomendaciones .titulo-recomendaciones {
  text-align: center;
  padding: 0px 0px 30px 0px; }

* {
  margin: 0px;
  padding: 0px; }

*::before,
*::after {
  box-sizing: border-box;
  margin: 0px;
  padding: 0px; }

html {
  box-sizing: border-box; }

body {
  background-color: #ffffff;
  font-family: "Open Sans", sans-serif;
  font-size: 16px; }

header {
  width: 100%;
  background-color: #ffffff; }

a {
  color: #46b271;
  transition: 0.5s ease; }
  a:hover {
    color: #009FFF; }

/*========= Header main ===================== */
.m-header {
  margin: 0px;
  padding: 0px;
  width: 100%; }
  @media screen and (max-width: 640px) {
    .m-header {
      display: none; } }
  .m-header .ls {
    padding-bottom: 10px;
    padding-top: 4px;
    box-sizing: border-box; }
    .m-header .ls .logo {
      display: block;
      max-width: 300px;
      min-width: 300px;
      height: auto; }
      .m-header .ls .logo img {
        width: 90%;
        display: block;
        vertical-align: top; }
        .m-header .ls .logo img:hover {
          filter: alpha(opacity=80);
          -moz-opacity: 1;
          opacity: calc(80 / 100);
          -khml-opacity: 1;
          transition: 0.5s ease;
          background-color: #ffffff; }

.m-header .sm {
  display: flex;
  flex-flow: row wrap;
  justify-content: flex-end;
  align-items: flex-end;
  align-content: flex-end;
  padding-top: 20px;
  box-sizing: border-box;
  text-align: right; }
  .m-header .sm .ubicacion {
    text-align: right;
    width: 100%;
    font-family: "Oswald", sans-serif;
    margin-bottom: 5px;
    margin-right: 20%; }
    .m-header .sm .ubicacion .icon {
      color: #b20013;
      margin-right: 5px; }
    .m-header .sm .ubicacion .search {
      width: 100%;
      margin: 0px auto;
      padding-top: 5px; }
      .m-header .sm .ubicacion .search .searchbar {
        text-align: center; }

input[type="text"],
input[type="tel"],
input[type="number"],
input[type="email"] {
  box-sizing: border-box;
  padding: 7px 10px;
  color: #333333;
  font-size: 0.9em;
  background: #ffffff;
  border-radius: 5px;
  border: 1px solid #b20013;
  font-weight: 300; }
  input[type="text"]:focus,
  input[type="tel"]:focus,
  input[type="number"]:focus,
  input[type="email"]:focus {
    color: #009FFF;
    border: 1px solid #46b271; }

textarea {
  box-sizing: border-box;
  padding: 7px 10px;
  color: #b20013;
  font-size: 0.9em;
  background: #ffffff;
  border-radius: 5px;
  border: 1px solid #b20013;
  font-weight: 300; }

input[type="submit"],
input[type="button"],
button[type="submit"] {
  box-sizing: border-box;
  box-sizing: border-box;
  padding: 7px 10px;
  color: #b20013;
  font-size: 0.9em;
  background: none;
  border-radius: 5px;
  border: none;
  font-weight: 300;
  cursor: pointer; }
  input[type="submit"]:hover,
  input[type="button"]:hover,
  button[type="submit"]:hover {
    color: #009FFF; }

input[type=number]::-webkit-inner-spin-button,
input[type=number]::-webkit-outer-spin-button {
  color: #b20013;
  font-weight: 600; }

.e-menu {
  background-color: #293449;
  width: 100%; }
  @media screen and (max-width: 640px) {
    .e-menu {
      padding: 10px 0px 10px; } }
  @media screen and (min-width: 640px) {
    .e-menu .navbar {
      display: none; } }
  .e-menu .navbar button.navbar-toggler {
    border: 1px solid #46b271;
    background-color: #46b271;
    transition: 0.5s ease;
    float: right; }
    .e-menu .navbar button.navbar-toggler .navbar-toggler-icon {
      color: #46b271; }
  .e-menu .navbar .navbar-brand {
    float: left; }
    .e-menu .navbar .navbar-brand img {
      width: 70px;
      transition: 0.5s ease; }
      .e-menu .navbar .navbar-brand img:hover {
        opacity: 0.8; }
  .e-menu .navbar .sm {
    margin: auto; }
    .e-menu .navbar .sm .ubicacion {
      text-align: center;
      margin-bottom: 10px; }
      .e-menu .navbar .sm .ubicacion .icon {
        color: #46b271; }
      .e-menu .navbar .sm .ubicacion #texto {
        color: #ffffff; }
    .e-menu .navbar .sm .search {
      color: #ffffff; }
      .e-menu .navbar .sm .search .searchbar {
        margin: 0px auto;
        display: flex;
        justify-content: center; }
        .e-menu .navbar .sm .search .searchbar input[type="text"] {
          border: 1px solid #46b271;
          outline: none;
          transition: 0.5s ease; }
          .e-menu .navbar .sm .search .searchbar input[type="text"]:hover {
            border: 1px solid #009FFF; }
        .e-menu .navbar .sm .search .searchbar input[type="submit"],
        .e-menu .navbar .sm .search .searchbar button[type="submit"] {
          color: #46b271;
          transition: 0.5s ease;
          outline: none; }
          .e-menu .navbar .sm .search .searchbar input[type="submit"]:hover,
          .e-menu .navbar .sm .search .searchbar button[type="submit"]:hover {
            color: #009FFF; }
  .e-menu div.collapse ul.menu {
    display: flex;
    flex-flow: column;
    flex-wrap: wrap;
    justify-content: center;
    padding: 10px 0px 10px;
    box-sizing: border-box;
    transition: 0.5s ease; }
    .e-menu div.collapse ul.menu li {
      transition: 0.5s ease;
      padding-top: 5px;
      padding-bottom: 5px;
      margin-bottom: 4px;
      padding-left: 10px;
      background-color: rgba(255, 255, 255, 0.2); }
      .e-menu div.collapse ul.menu li a {
        padding: 5px 0px 5px;
        transition: 0.5s ease;
        color: #ffffff;
        text-decoration: none;
        font-size: 1.125em;
        display: block; }
        .e-menu div.collapse ul.menu li a:hover {
          color: #46b271; }

@media screen and (max-width: 640px) {
  .e-menu .navbar-me {
    display: none; } }
.e-menu .navbar-me ul.menu {
  display: flex;
  flex-flow: row;
  flex-wrap: wrap;
  justify-content: center; }
  .e-menu .navbar-me ul.menu li {
    position: relative;
    padding: 0px 0px 0px;
    --ttw: 100%; }
    .e-menu .navbar-me ul.menu li:hover {
      transition: 0.5s ease; }
      .e-menu .navbar-me ul.menu li:hover:after {
        width: 100%;
        content: "";
        display: block;
        background-color: #46b271;
        height: 3px;
        width: calc(var(--ttw)/2);
        position: absolute;
        left: calc( calc( 100% - ( calc(var(--ttw)/2)) ) / 2 );
        bottom: 0px;
        z-index: 100;
        transition: 0.5s ease; }
    .e-menu .navbar-me ul.menu li a {
      padding: 20px 10px 20px;
      display: block;
      color: #ffffff;
      text-decoration: none; }
      .e-menu .navbar-me ul.menu li a:hover {
        color: #46b271; }

.slide {
  width: 100%;
  margin: 0px auto;
  padding: 0px;
  box-sizing: border-box;
  overflow: hidden;
  background-color: #ffffff; }
  .slide .metaslider {
    box-sizing: border-box;
    margin: 0px auto;
    text-align: center;
    min-height: 100%;
    max-width: 100%;
    min-width: 100%; }
    @media screen and (max-width: 640px) {
      .slide .metaslider .slides img {
        min-height: 100%; } }
    .slide .metaslider .flexslider {
      padding: 0px;
      margin: 0px;
      background-color: green; }
      .slide .metaslider .flexslider .flex-control-nav {
        padding: 20px;
        background-color: rgba(255, 255, 255, 0.5);
        width: 100%;
        bottom: 0px;
        z-index: 100;
        height: auto; }
        @media screen and (max-width: 640px) {
          .slide .metaslider .flexslider .flex-control-nav {
            display: none;
            background-color: #293449;
            z-index: 150; } }
  .slide .soliloquy-container {
    width: 100%;
    margin: 0px auto; }
  .slide img {
    box-sizing: border-box;
    width: 100%;
    margin: 0px auto;
    vertical-align: top; }

/*======= vien de coverpage.sass */
.m-iparroquial {
  background-color: #f2f2f2;
  box-sizing: border-box;
  padding: 30px;
  width: 100%; }
  .m-iparroquial .titulo-anuncios {
    padding: 10px;
    width: var(--sizem);
    text-align: center;
    box-sizing: border-box;
    margin-bottom: 30px; }
    .m-iparroquial .titulo-anuncios h3 {
      position: relative;
      margin: auto;
      --width: 20%;
      color: #293449;
      font-weight: bold; }
      .m-iparroquial .titulo-anuncios h3::after {
        content: "";
        display: block;
        height: 3px;
        width: calc(var(--width)/2);
        position: absolute;
        left: calc( calc( 100% - ( calc(var(--width)/2)) ) / 2 );
        bottom: -0.8em;
        background-color: #b20013;
        z-index: 100; }

/*=============== cuadro de selecciona tu iglesia ==== */
.m-iparroquial #iglesia {
  min-height: 50px;
  display: flex;
  flex-flow: row wrap;
  box-sizing: border-box;
  justify-content: center; }
  .m-iparroquial #iglesia #div1 {
    width: calc(var(--sizem)/4);
    min-height: 150px;
    padding: 10px 10px 10px 10px;
    text-align: center;
    box-sizing: border-box; }
    @media screen and (max-width: 600px) {
      .m-iparroquial #iglesia #div1 {
        width: calc(var(--sizem)/2);
        padding: 5px; } }
    .m-iparroquial #iglesia #div1 a {
      color: #293449;
      font-family: "Oswald", sans-serif;
      text-transform: uppercase;
      text-decoration: none;
      padding: 0px 0px 8px 0px;
      display: block;
      background-color: #ffffff;
      margin: 10px;
      border: 1px solid #ffffff; }
      .m-iparroquial #iglesia #div1 a:hover {
        color: #b20013;
        transition: 0.5s ease;
        -o-transition: 0.5s ease;
        -webkit-transition: 0.5s ease; }
      .m-iparroquial #iglesia #div1 a span {
        margin-top: 20px;
        display: block; }
      .m-iparroquial #iglesia #div1 a img {
        width: 100%;
        height: 100%;
        background-size: cover; }
        .m-iparroquial #iglesia #div1 a img:hover {
          transition: 0.5s ease;
          opacity: 0.5; }

/*=============================================================== */
.section-bienvenida {
  width: var(--sizem);
  padding: 20px;
  background-color: #f2f2f2; }
  .section-bienvenida .texto-bienvenida {
    text-align: center; }
  .section-bienvenida .i-bienvenida {
    padding: 10px;
    width: var(--sizem);
    text-align: center;
    box-sizing: border-box;
    margin-bottom: 30px; }
    .section-bienvenida .i-bienvenida h3 {
      position: relative;
      margin: auto;
      --width: 20%;
      color: #293449;
      font-weight: bold; }
      .section-bienvenida .i-bienvenida h3::after {
        content: "";
        display: block;
        height: 3px;
        width: calc(var(--width)/2);
        position: absolute;
        left: calc( calc( 100% - ( calc(var(--width)/2)) ) / 2 );
        bottom: -0.8em;
        background-color: #b20013;
        z-index: 100; }

.con-general {
  background-color: #ffffff;
  padding-top: 10px; }
  .con-general .con {
    margin-bottom: 20px; }
    .con-general .con img {
      max-width: 100%;
      height: auto; }
    .con-general .con .alignleft {
      float: left;
      margin: 20px 20px 20px 0px; }
    .con-general .con .alignright {
      float: right;
      margin: 20px 0px 20px 20px; }
    .con-general .con .aligncenter {
      width: 100%;
      height: auto;
      margin: 5px auto; }
    .con-general .con .bread {
      background-color: none;
      padding: 10px;
      color: #ffffff; }
      .con-general .con .bread .mapeo {
        color: #293449; }
        .con-general .con .bread .mapeo span {
          margin-left: 5px;
          margin-right: 5px; }
          .con-general .con .bread .mapeo span a {
            color: #009FFF;
            text-decoration: none;
            transition: 0.5s ease; }
            .con-general .con .bread .mapeo span a:hover {
              color: #46b271; }

/*=========remodelacion============= */
.m-remodelacion {
  background-color: #ffffff;
  padding: 20px;
  text-align: center; }
  .m-remodelacion .title-recomendacion {
    padding: 10px;
    width: var(--sizem);
    text-align: center;
    box-sizing: border-box;
    margin-bottom: 30px; }
    .m-remodelacion .title-recomendacion h3 {
      position: relative;
      margin: auto;
      --width: 20%;
      color: #293449;
      font-weight: bold; }
      .m-remodelacion .title-recomendacion h3::after {
        content: "";
        display: block;
        height: 3px;
        width: calc(var(--width)/2);
        position: absolute;
        left: calc( calc( 100% - ( calc(var(--width)/2)) ) / 2 );
        bottom: -0.8em;
        background-color: #b20013;
        z-index: 100; }
  .m-remodelacion .contenidos-c .thumb {
    display: block; }
  .m-remodelacion .contenidos-c .link {
    margin-top: 10px;
    display: block; }

/*===================== Entradas recientes cover page ==================== */
.m-entradas-recientes {
  width: var(--sizem);
  padding: 20px;
  background-color: #ffffff;
  box-sizing: border-box; }
  .m-entradas-recientes .titulo-entradas-reciente {
    padding: 10px;
    width: var(--sizem);
    text-align: center;
    box-sizing: border-box;
    margin-bottom: 30px; }
    .m-entradas-recientes .titulo-entradas-reciente h3 {
      position: relative;
      margin: auto;
      --width: 20%;
      color: #293449;
      font-weight: bold; }
      .m-entradas-recientes .titulo-entradas-reciente h3::after {
        content: "";
        display: block;
        height: 3px;
        width: calc(var(--width)/2);
        position: absolute;
        left: calc( calc( 100% - ( calc(var(--width)/2)) ) / 2 );
        bottom: -0.8em;
        background-color: #b20013;
        z-index: 100; }
  .m-entradas-recientes .listado-entradas {
    display: flex;
    flex-flow: row wrap;
    box-sizing: border-box;
    justify-content: center;
    align-items: stretch; }
    .m-entradas-recientes .listado-entradas .lista {
      width: calc(var(--sizem)/4);
      min-height: 150px;
      text-align: center;
      box-sizing: border-box; }
      .m-entradas-recientes .listado-entradas .lista a {
        color: #293449;
        font-family: "Oswald", sans-serif;
        text-transform: uppercase;
        font-size: 0.9em;
        text-decoration: none;
        padding: 0px 0px 8px 0px;
        display: block;
        background-color: #ffffff;
        margin: 10px; }
        .m-entradas-recientes .listado-entradas .lista a:hover {
          color: #b20013;
          transition: 0.5s ease;
          -o-transition: 0.5s ease;
          -webkit-transition: 0.5s ease; }
        .m-entradas-recientes .listado-entradas .lista a .texto {
          display: block;
          height: 50px;
          display: flex;
          align-items: center;
          justify-content: center; }
        .m-entradas-recientes .listado-entradas .lista a img {
          width: 100%;
          height: 200px;
          background-size: cover; }
          .m-entradas-recientes .listado-entradas .lista a img:hover {
            transition: 0.5s ease;
            opacity: 0.5; }

#totop {
  display: none;
  text-decoration: none;
  position: fixed;
  bottom: 40px;
  margin-left: 640px;
  overflow: hidden;
  width: 43px;
  height: 28px;
  border: none;
  text-indent: -999px;
  z-index: 20;
  background: url("../images/totop.png") no-repeat left 0;
  transition: 0s ease;
  -o-transition: 0s ease;
  -webkit-transition: 0s ease; }
  #totop:hover {
    outline: none;
    background-position: right 0; }

footer {
  width: 100%;
  background-color: #293449; }
  footer #pie {
    background-color: #293449;
    min-height: 150px; }
    footer #pie .group {
      padding: 50px;
      text-align: center;
      color: #ffffff;
      line-height: 1.5em;
      font-family: "Economica-Bold";
      text-shadow: 1px 2px 1px #000;
      font-size: 1.2em; }
      footer #pie .group a {
        color: #009FFF;
        text-decoration: none; }
        footer #pie .group a:hover {
          color: #f7b32b;
          transition: 0.5s ease; }

.con-general .con .interiores {
  padding-top: 20px; }
.con-general .side {
  padding-top: 20px; }
  .con-general .side .entradas {
    background-color: #f2f2f2; }
    .con-general .side .entradas .titulo_entradas {
      background-color: #009FFF;
      padding: 24px 0px 17px 25px;
      box-sizing: border-box; }
      .con-general .side .entradas .titulo_entradas h3 {
        font-size: 1.2em;
        color: #ffffff;
        text-transform: uppercase;
        font-family: "Oswald", sans-serif;
        margin: 0px;
        padding: 0px; }
.con-general .side .entradas .recientes {
  margin-bottom: 20px;
  padding-left: 10px;
  padding-right: 10px;
  padding-top: 10px; }
  .con-general .side .entradas .recientes .list {
    padding: 5px;
    margin-bottom: 5px;
    padding-bottom: 9px;
    overflow: hidden;
    border-bottom: 1px solid #009FFF;
    text-transform: lowercase;
    display: flex;
    flex-flow: row wrap;
    justify-content: space-between;
    align-items: center;
    box-sizing: border-box; }
    .con-general .side .entradas .recientes .list .thumb {
      width: 20%; }
      .con-general .side .entradas .recientes .list .thumb img {
        height: auto;
        display: inline-block;
        float: left;
        margin-right: 7px;
        box-shadow: 0 0 8px rgba(0, 0, 0, 0.8);
        border: 2px solid #ffffff;
        width: 90%; }
        .con-general .side .entradas .recientes .list .thumb img:hover {
          filter: alpha(opacity=50);
          -moz-opacity: 1;
          opacity: 0.5;
          -khml-opacity: 1;
          transition: 0.5s ease;
          box-shadow: 0 0 8px rgba(0, 120, 240, 0.8); }

.con-general .side .entradas .recientes .list .title {
  color: #009FFF;
  line-height: 1.3em;
  font-size: 1.1em;
  text-decoration: none;
  width: 78%;
  text-transform: lowercase; }
  .con-general .side .entradas .recientes .list .title:hover {
    color: #d53132;
    transition: 0.5s ease;
    -o-transition: 0.5s ease;
    -webkit-transition: 0.5s ease; }
  .con-general .side .entradas .recientes .list .title:first-letter {
    text-transform: uppercase; }

.navigation {
  background-color: #46b271;
  padding: 7px;
  width: 100%; }
  .navigation .pagenavi {
    margin-top: 10px;
    margin-bottom: 10px;
    text-align: left;
    width: 100%;
    display: flex;
    flex-flow: row wrap;
    justify-content: center; }
    .navigation .pagenavi span {
      border-radius: 3px; }
    .navigation .pagenavi a {
      border-radius: 3px; }
      .navigation .pagenavi a:last-child {
        color: #ffffff;
        padding: 3px;
        margin-left: 7px;
        transition: 0.5s ease; }
      .navigation .pagenavi a:nth-child(2) {
        color: #ffffff;
        padding: 3px;
        margin-right: 7px; }
      .navigation .pagenavi a:hover {
        transition: 0.5s ease;
        color: #333333; }
    .navigation .pagenavi .pages {
      padding: 4px;
      margin-left: 4px;
      margin-right: 10px;
      color: #333333;
      width: 100%;
      text-align: center; }
      .navigation .pagenavi .pages a {
        padding: 4px;
        margin: 4px; }
      .navigation .pagenavi .pages:last {
        content: ">>"; }
    .navigation .pagenavi .current {
      padding: 4px;
      background-color: #b20013;
      color: #ffffff;
      margin: 4px; }
    .navigation .pagenavi .first {
      padding: 4px;
      background-color: #333333;
      color: #46b271;
      margin: 4px;
      border-radius: 3px; }
      .navigation .pagenavi .first:hover {
        background-color: #ffffff;
        transition: 0.5s ease; }
    .navigation .pagenavi .single_page {
      padding: 4px;
      background-color: #333333;
      color: #46b271;
      margin: 4px;
      border-radius: 3px; }
      .navigation .pagenavi .single_page:hover {
        background-color: #ffffff;
        transition: 0.5s ease; }
    .navigation .pagenavi .last {
      padding: 4px;
      background-color: #333333;
      color: #46b271;
      margin: 4px;
      border-radius: 3px; }
      .navigation .pagenavi .last:hover {
        background-color: #ffffff;
        transition: 0.5s ease; }

/*# sourceMappingURL=estilo.cs.map */
