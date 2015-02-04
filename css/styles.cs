/*! normalize.css v3.0.1 | MIT License | git.io/normalize */
html {
  font-family: sans-serif;
  -ms-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%; }

body {
  margin: 0; }

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
nav,
section,
summary {
  display: block; }

audio,
canvas,
progress,
video {
  display: inline-block;
  vertical-align: baseline; }

audio:not([controls]) {
  display: none;
  height: 0; }

[hidden],
template {
  display: none; }

a {
  background: transparent; }

a:active,
a:hover {
  outline: 0; }

abbr[title] {
  border-bottom: 1px dotted; }

b,
strong {
  font-weight: bold; }

dfn {
  font-style: italic; }

h1 {
  font-size: 2em;
  margin: 0.67em 0; }

mark {
  background: #ff0;
  color: #000; }

small {
  font-size: 80%; }

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline; }

sup {
  top: -0.5em; }

sub {
  bottom: -0.25em; }

img {
  border: 0; }

svg:not(:root) {
  overflow: hidden; }

figure {
  margin: 1em 40px; }

hr {
  -moz-box-sizing: content-box;
  box-sizing: content-box;
  height: 0; }

pre {
  overflow: auto; }

code,
kbd,
pre,
samp {
  font-family: monospace, monospace;
  font-size: 1em; }

button,
input,
optgroup,
select,
textarea {
  color: inherit;
  font: inherit;
  margin: 0; }

button {
  overflow: visible; }

button,
select {
  text-transform: none; }

button,
html input[type="button"],
input[type="reset"],
input[type="submit"] {
  -webkit-appearance: button;
  cursor: pointer; }

button[disabled],
html input[disabled] {
  cursor: default; }

button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0; }

input {
  line-height: normal; }

input[type="checkbox"],
input[type="radio"] {
  box-sizing: border-box;
  padding: 0; }

input[type="number"]::-webkit-inner-spin-button,
input[type="number"]::-webkit-outer-spin-button {
  height: auto; }

input[type="search"] {
  -webkit-appearance: textfield;
  -moz-box-sizing: content-box;
  -webkit-box-sizing: content-box;
  box-sizing: content-box; }

input[type="search"]::-webkit-search-cancel-button,
input[type="search"]::-webkit-search-decoration {
  -webkit-appearance: none; }

fieldset {
  border: 1px solid #c0c0c0;
  margin: 0 2px;
  padding: 0.35em 0.625em 0.75em; }

legend {
  border: 0;
  padding: 0; }

textarea {
  overflow: auto; }

optgroup {
  font-weight: bold; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

td,
th {
  padding: 0; }

@media print {
  * {
    text-shadow: none !important;
    color: #000 !important;
    background: transparent !important;
    box-shadow: none !important; }

  a,
  a:visited {
    text-decoration: underline; }

  a[href]:after {
    content: " (" attr(href) ")"; }

  abbr[title]:after {
    content: " (" attr(title) ")"; }

  a[href^="javascript:"]:after,
  a[href^="#"]:after {
    content: ""; }

  pre,
  blockquote {
    border: 1px solid #999;
    page-break-inside: avoid; }

  thead {
    display: table-header-group; }

  tr,
  img {
    page-break-inside: avoid; }

  img {
    max-width: 100% !important; }

  p,
  h2,
  h3 {
    orphans: 3;
    widows: 3; }

  h2,
  h3 {
    page-break-after: avoid; }

  select {
    background: #fff !important; }

  .navbar {
    display: none; }

  .table td,
  .table th {
    background-color: #fff !important; }

  .btn > .caret,
  .dropup > .btn > .caret {
    border-top-color: #000 !important; }

  .label {
    border: 1px solid #000; }

  .table {
    border-collapse: collapse !important; }

  .table-bordered th,
  .table-bordered td {
    border: 1px solid #ddd !important; } }
@font-face {
  font-family: 'Glyphicons Halflings';
  src: url("bootstrap/glyphicons-halflings-regular.eot");
  src: url("bootstrap/glyphicons-halflings-regular.eot?#iefix") format("embedded-opentype"), url("bootstrap/glyphicons-halflings-regular.woff") format("woff"), url("bootstrap/glyphicons-halflings-regular.ttf") format("truetype"), url("bootstrap/glyphicons-halflings-regular.svg#glyphicons_halflingsregular") format("svg"); }
.glyphicon {
  position: relative;
  top: 1px;
  display: inline-block;
  font-family: 'Glyphicons Halflings';
  font-style: normal;
  font-weight: normal;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale; }

.glyphicon-asterisk:before {
  content: "\2a"; }

.glyphicon-plus:before {
  content: "\2b"; }

.glyphicon-euro:before {
  content: "\20ac"; }

.glyphicon-minus:before {
  content: "\2212"; }

.glyphicon-cloud:before {
  content: "\2601"; }

.glyphicon-envelope:before {
  content: "\2709"; }

.glyphicon-pencil:before {
  content: "\270f"; }

.glyphicon-glass:before {
  content: "\e001"; }

.glyphicon-music:before {
  content: "\e002"; }

.glyphicon-search:before {
  content: "\e003"; }

.glyphicon-heart:before {
  content: "\e005"; }

.glyphicon-star:before {
  content: "\e006"; }

.glyphicon-star-empty:before {
  content: "\e007"; }

.glyphicon-user:before {
  content: "\e008"; }

.glyphicon-film:before {
  content: "\e009"; }

.glyphicon-th-large:before {
  content: "\e010"; }

.glyphicon-th:before {
  content: "\e011"; }

.glyphicon-th-list:before {
  content: "\e012"; }

.glyphicon-ok:before {
  content: "\e013"; }

.glyphicon-remove:before {
  content: "\e014"; }

.glyphicon-zoom-in:before {
  content: "\e015"; }

.glyphicon-zoom-out:before {
  content: "\e016"; }

.glyphicon-off:before {
  content: "\e017"; }

.glyphicon-signal:before {
  content: "\e018"; }

.glyphicon-cog:before {
  content: "\e019"; }

.glyphicon-trash:before {
  content: "\e020"; }

.glyphicon-home:before {
  content: "\e021"; }

.glyphicon-file:before {
  content: "\e022"; }

.glyphicon-time:before {
  content: "\e023"; }

.glyphicon-road:before {
  content: "\e024"; }

.glyphicon-download-alt:before {
  content: "\e025"; }

.glyphicon-download:before {
  content: "\e026"; }

.glyphicon-upload:before {
  content: "\e027"; }

.glyphicon-inbox:before {
  content: "\e028"; }

.glyphicon-play-circle:before {
  content: "\e029"; }

.glyphicon-repeat:before {
  content: "\e030"; }

.glyphicon-refresh:before {
  content: "\e031"; }

.glyphicon-list-alt:before {
  content: "\e032"; }

.glyphicon-lock:before {
  content: "\e033"; }

.glyphicon-flag:before {
  content: "\e034"; }

.glyphicon-headphones:before {
  content: "\e035"; }

.glyphicon-volume-off:before {
  content: "\e036"; }

.glyphicon-volume-down:before {
  content: "\e037"; }

.glyphicon-volume-up:before {
  content: "\e038"; }

.glyphicon-qrcode:before {
  content: "\e039"; }

.glyphicon-barcode:before {
  content: "\e040"; }

.glyphicon-tag:before {
  content: "\e041"; }

.glyphicon-tags:before {
  content: "\e042"; }

.glyphicon-book:before {
  content: "\e043"; }

.glyphicon-bookmark:before {
  content: "\e044"; }

.glyphicon-print:before {
  content: "\e045"; }

.glyphicon-camera:before {
  content: "\e046"; }

.glyphicon-font:before {
  content: "\e047"; }

.glyphicon-bold:before {
  content: "\e048"; }

.glyphicon-italic:before {
  content: "\e049"; }

.glyphicon-text-height:before {
  content: "\e050"; }

.glyphicon-text-width:before {
  content: "\e051"; }

.glyphicon-align-left:before {
  content: "\e052"; }

.glyphicon-align-center:before {
  content: "\e053"; }

.glyphicon-align-right:before {
  content: "\e054"; }

.glyphicon-align-justify:before {
  content: "\e055"; }

.glyphicon-list:before {
  content: "\e056"; }

.glyphicon-indent-left:before {
  content: "\e057"; }

.glyphicon-indent-right:before {
  content: "\e058"; }

.glyphicon-facetime-video:before {
  content: "\e059"; }

.glyphicon-picture:before {
  content: "\e060"; }

.glyphicon-map-marker:before {
  content: "\e062"; }

.glyphicon-adjust:before {
  content: "\e063"; }

.glyphicon-tint:before {
  content: "\e064"; }

.glyphicon-edit:before {
  content: "\e065"; }

.glyphicon-share:before {
  content: "\e066"; }

.glyphicon-check:before {
  content: "\e067"; }

.glyphicon-move:before {
  content: "\e068"; }

.glyphicon-step-backward:before {
  content: "\e069"; }

.glyphicon-fast-backward:before {
  content: "\e070"; }

.glyphicon-backward:before {
  content: "\e071"; }

.glyphicon-play:before {
  content: "\e072"; }

.glyphicon-pause:before {
  content: "\e073"; }

.glyphicon-stop:before {
  content: "\e074"; }

.glyphicon-forward:before {
  content: "\e075"; }

.glyphicon-fast-forward:before {
  content: "\e076"; }

.glyphicon-step-forward:before {
  content: "\e077"; }

.glyphicon-eject:before {
  content: "\e078"; }

.glyphicon-chevron-left:before {
  content: "\e079"; }

.glyphicon-chevron-right:before {
  content: "\e080"; }

.glyphicon-plus-sign:before {
  content: "\e081"; }

.glyphicon-minus-sign:before {
  content: "\e082"; }

.glyphicon-remove-sign:before {
  content: "\e083"; }

.glyphicon-ok-sign:before {
  content: "\e084"; }

.glyphicon-question-sign:before {
  content: "\e085"; }

.glyphicon-info-sign:before {
  content: "\e086"; }

.glyphicon-screenshot:before {
  content: "\e087"; }

.glyphicon-remove-circle:before {
  content: "\e088"; }

.glyphicon-ok-circle:before {
  content: "\e089"; }

.glyphicon-ban-circle:before {
  content: "\e090"; }

.glyphicon-arrow-left:before {
  content: "\e091"; }

.glyphicon-arrow-right:before {
  content: "\e092"; }

.glyphicon-arrow-up:before {
  content: "\e093"; }

.glyphicon-arrow-down:before {
  content: "\e094"; }

.glyphicon-share-alt:before {
  content: "\e095"; }

.glyphicon-resize-full:before {
  content: "\e096"; }

.glyphicon-resize-small:before {
  content: "\e097"; }

.glyphicon-exclamation-sign:before {
  content: "\e101"; }

.glyphicon-gift:before {
  content: "\e102"; }

.glyphicon-leaf:before {
  content: "\e103"; }

.glyphicon-fire:before {
  content: "\e104"; }

.glyphicon-eye-open:before {
  content: "\e105"; }

.glyphicon-eye-close:before {
  content: "\e106"; }

.glyphicon-warning-sign:before {
  content: "\e107"; }

.glyphicon-plane:before {
  content: "\e108"; }

.glyphicon-calendar:before {
  content: "\e109"; }

.glyphicon-random:before {
  content: "\e110"; }

.glyphicon-comment:before {
  content: "\e111"; }

.glyphicon-magnet:before {
  content: "\e112"; }

.glyphicon-chevron-up:before {
  content: "\e113"; }

.glyphicon-chevron-down:before {
  content: "\e114"; }

.glyphicon-retweet:before {
  content: "\e115"; }

.glyphicon-shopping-cart:before {
  content: "\e116"; }

.glyphicon-folder-close:before {
  content: "\e117"; }

.glyphicon-folder-open:before {
  content: "\e118"; }

.glyphicon-resize-vertical:before {
  content: "\e119"; }

.glyphicon-resize-horizontal:before {
  content: "\e120"; }

.glyphicon-hdd:before {
  content: "\e121"; }

.glyphicon-bullhorn:before {
  content: "\e122"; }

.glyphicon-bell:before {
  content: "\e123"; }

.glyphicon-certificate:before {
  content: "\e124"; }

.glyphicon-thumbs-up:before {
  content: "\e125"; }

.glyphicon-thumbs-down:before {
  content: "\e126"; }

.glyphicon-hand-right:before {
  content: "\e127"; }

.glyphicon-hand-left:before {
  content: "\e128"; }

.glyphicon-hand-up:before {
  content: "\e129"; }

.glyphicon-hand-down:before {
  content: "\e130"; }

.glyphicon-circle-arrow-right:before {
  content: "\e131"; }

.glyphicon-circle-arrow-left:before {
  content: "\e132"; }

.glyphicon-circle-arrow-up:before {
  content: "\e133"; }

.glyphicon-circle-arrow-down:before {
  content: "\e134"; }

.glyphicon-globe:before {
  content: "\e135"; }

.glyphicon-wrench:before {
  content: "\e136"; }

.glyphicon-tasks:before {
  content: "\e137"; }

.glyphicon-filter:before {
  content: "\e138"; }

.glyphicon-briefcase:before {
  content: "\e139"; }

.glyphicon-fullscreen:before {
  content: "\e140"; }

.glyphicon-dashboard:before {
  content: "\e141"; }

.glyphicon-paperclip:before {
  content: "\e142"; }

.glyphicon-heart-empty:before {
  content: "\e143"; }

.glyphicon-link:before {
  content: "\e144"; }

.glyphicon-phone:before {
  content: "\e145"; }

.glyphicon-pushpin:before {
  content: "\e146"; }

.glyphicon-usd:before {
  content: "\e148"; }

.glyphicon-gbp:before {
  content: "\e149"; }

.glyphicon-sort:before {
  content: "\e150"; }

.glyphicon-sort-by-alphabet:before {
  content: "\e151"; }

.glyphicon-sort-by-alphabet-alt:before {
  content: "\e152"; }

.glyphicon-sort-by-order:before {
  content: "\e153"; }

.glyphicon-sort-by-order-alt:before {
  content: "\e154"; }

.glyphicon-sort-by-attributes:before {
  content: "\e155"; }

.glyphicon-sort-by-attributes-alt:before {
  content: "\e156"; }

.glyphicon-unchecked:before {
  content: "\e157"; }

.glyphicon-expand:before {
  content: "\e158"; }

.glyphicon-collapse-down:before {
  content: "\e159"; }

.glyphicon-collapse-up:before {
  content: "\e160"; }

.glyphicon-log-in:before {
  content: "\e161"; }

.glyphicon-flash:before {
  content: "\e162"; }

.glyphicon-log-out:before {
  content: "\e163"; }

.glyphicon-new-window:before {
  content: "\e164"; }

.glyphicon-record:before {
  content: "\e165"; }

.glyphicon-save:before {
  content: "\e166"; }

.glyphicon-open:before {
  content: "\e167"; }

.glyphicon-saved:before {
  content: "\e168"; }

.glyphicon-import:before {
  content: "\e169"; }

.glyphicon-export:before {
  content: "\e170"; }

.glyphicon-send:before {
  content: "\e171"; }

.glyphicon-floppy-disk:before {
  content: "\e172"; }

.glyphicon-floppy-saved:before {
  content: "\e173"; }

.glyphicon-floppy-remove:before {
  content: "\e174"; }

.glyphicon-floppy-save:before {
  content: "\e175"; }

.glyphicon-floppy-open:before {
  content: "\e176"; }

.glyphicon-credit-card:before {
  content: "\e177"; }

.glyphicon-transfer:before {
  content: "\e178"; }

.glyphicon-cutlery:before {
  content: "\e179"; }

.glyphicon-header:before {
  content: "\e180"; }

.glyphicon-compressed:before {
  content: "\e181"; }

.glyphicon-earphone:before {
  content: "\e182"; }

.glyphicon-phone-alt:before {
  content: "\e183"; }

.glyphicon-tower:before {
  content: "\e184"; }

.glyphicon-stats:before {
  content: "\e185"; }

.glyphicon-sd-video:before {
  content: "\e186"; }

.glyphicon-hd-video:before {
  content: "\e187"; }

.glyphicon-subtitles:before {
  content: "\e188"; }

.glyphicon-sound-stereo:before {
  content: "\e189"; }

.glyphicon-sound-dolby:before {
  content: "\e190"; }

.glyphicon-sound-5-1:before {
  content: "\e191"; }

.glyphicon-sound-6-1:before {
  content: "\e192"; }

.glyphicon-sound-7-1:before {
  content: "\e193"; }

.glyphicon-copyright-mark:before {
  content: "\e194"; }

.glyphicon-registration-mark:before {
  content: "\e195"; }

.glyphicon-cloud-download:before {
  content: "\e197"; }

.glyphicon-cloud-upload:before {
  content: "\e198"; }

.glyphicon-tree-conifer:before {
  content: "\e199"; }

.glyphicon-tree-deciduous:before {
  content: "\e200"; }

* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

*:before,
*:after {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

html {
  font-size: 62.5%;
  -webkit-tap-highlight-color: transparent; }

body {
  font-family: "Helvetica Neue", Helvetica, Arial, sans-serif;
  font-size: 14px;
  line-height: 1.42857;
  color: #333333;
  background-color: white; }

input,
button,
select,
textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit; }

a {
  color: #428bca;
  text-decoration: none; }
  a:hover, a:focus {
    color: #2a6496;
    text-decoration: underline; }
  a:focus {
    outline: thin dotted;
    outline: 5px auto -webkit-focus-ring-color;
    outline-offset: -2px; }

figure {
  margin: 0; }

img {
  vertical-align: middle; }

.img-responsive {
  display: block;
  max-width: 100%;
  height: auto; }

.img-rounded {
  border-radius: 6px; }

.img-thumbnail {
  padding: 4px;
  line-height: 1.42857;
  background-color: white;
  border: 1px solid #dddddd;
  border-radius: 4px;
  -webkit-transition: all 0.2s ease-in-out;
  -o-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  display: inline-block;
  max-width: 100%;
  height: auto; }

.img-circle {
  border-radius: 50%; }

hr {
  margin-top: 20px;
  margin-bottom: 20px;
  border: 0;
  border-top: 1px solid #eeeeee; }

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  margin: -1px;
  padding: 0;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  border: 0; }

.sr-only-focusable:active, .sr-only-focusable:focus {
  position: static;
  width: auto;
  height: auto;
  margin: 0;
  overflow: visible;
  clip: auto; }

h1, h2, h3, h4, h5, h6,
.h1, .h2, .h3, .h4, .h5, .h6 {
  font-family: inherit;
  font-weight: 500;
  line-height: 1.1;
  color: inherit; }
  h1 small,
  h1 .small, h2 small,
  h2 .small, h3 small,
  h3 .small, h4 small,
  h4 .small, h5 small,
  h5 .small, h6 small,
  h6 .small,
  .h1 small,
  .h1 .small, .h2 small,
  .h2 .small, .h3 small,
  .h3 .small, .h4 small,
  .h4 .small, .h5 small,
  .h5 .small, .h6 small,
  .h6 .small {
    font-weight: normal;
    line-height: 1;
    color: #999999; }

h1, .h1,
h2, .h2,
h3, .h3 {
  margin-top: 20px;
  margin-bottom: 10px; }
  h1 small,
  h1 .small, .h1 small,
  .h1 .small,
  h2 small,
  h2 .small, .h2 small,
  .h2 .small,
  h3 small,
  h3 .small, .h3 small,
  .h3 .small {
    font-size: 65%; }

h4, .h4,
h5, .h5,
h6, .h6 {
  margin-top: 10px;
  margin-bottom: 10px; }
  h4 small,
  h4 .small, .h4 small,
  .h4 .small,
  h5 small,
  h5 .small, .h5 small,
  .h5 .small,
  h6 small,
  h6 .small, .h6 small,
  .h6 .small {
    font-size: 75%; }

h1, .h1 {
  font-size: 36px; }

h2, .h2 {
  font-size: 30px; }

h3, .h3 {
  font-size: 24px; }

h4, .h4 {
  font-size: 18px; }

h5, .h5 {
  font-size: 14px; }

h6, .h6 {
  font-size: 12px; }

p {
  margin: 0 0 10px; }

.lead {
  margin-bottom: 20px;
  font-size: 16px;
  font-weight: 300;
  line-height: 1.4; }
  @media (min-width: 768px) {
    .lead {
      font-size: 21px; } }

small,
.small {
  font-size: 85%; }

cite {
  font-style: normal; }

mark,
.mark {
  background-color: #fcf8e3;
  padding: .2em; }

.text-left {
  text-align: left; }

.text-right {
  text-align: right; }

.text-center {
  text-align: center; }

.text-justify {
  text-align: justify; }

.text-muted {
  color: #999999; }

.text-primary {
  color: #428bca; }

a.text-primary:hover {
  color: #3071a9; }

.text-success {
  color: #3c763d; }

a.text-success:hover {
  color: #2b542c; }

.text-info {
  color: #31708f; }

a.text-info:hover {
  color: #245269; }

.text-warning {
  color: #8a6d3b; }

a.text-warning:hover {
  color: #66512c; }

.text-danger {
  color: #a94442; }

a.text-danger:hover {
  color: #843534; }

.bg-primary {
  color: #fff; }

.bg-primary {
  background-color: #428bca; }

a.bg-primary:hover {
  background-color: #3071a9; }

.bg-success {
  background-color: #dff0d8; }

a.bg-success:hover {
  background-color: #c1e2b3; }

.bg-info {
  background-color: #d9edf7; }

a.bg-info:hover {
  background-color: #afd9ee; }

.bg-warning {
  background-color: #fcf8e3; }

a.bg-warning:hover {
  background-color: #f7ecb5; }

.bg-danger {
  background-color: #f2dede; }

a.bg-danger:hover {
  background-color: #e4b9b9; }

.page-header {
  padding-bottom: 9px;
  margin: 40px 0 20px;
  border-bottom: 1px solid #eeeeee; }

ul,
ol {
  margin-top: 0;
  margin-bottom: 10px; }
  ul ul,
  ul ol,
  ol ul,
  ol ol {
    margin-bottom: 0; }

.list-unstyled, .list-inline {
  padding-left: 0;
  list-style: none; }

.list-inline {
  margin-left: -5px; }
  .list-inline > li {
    display: inline-block;
    padding-left: 5px;
    padding-right: 5px; }

dl {
  margin-top: 0;
  margin-bottom: 20px; }

dt,
dd {
  line-height: 1.42857; }

dt {
  font-weight: bold; }

dd {
  margin-left: 0; }

.dl-horizontal dd:before, .dl-horizontal dd:after {
  content: " ";
  display: table; }
.dl-horizontal dd:after {
  clear: both; }
@media (min-width: 768px) {
  .dl-horizontal dt {
    float: left;
    width: 160px;
    clear: left;
    text-align: right;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap; }
  .dl-horizontal dd {
    margin-left: 180px; } }

abbr[title],
abbr[data-original-title] {
  cursor: help;
  border-bottom: 1px dotted #999999; }

.initialism {
  font-size: 90%;
  text-transform: uppercase; }

blockquote {
  padding: 10px 20px;
  margin: 0 0 20px;
  font-size: 17.5px;
  border-left: 5px solid #eeeeee; }
  blockquote p:last-child,
  blockquote ul:last-child,
  blockquote ol:last-child {
    margin-bottom: 0; }
  blockquote footer,
  blockquote small,
  blockquote .small {
    display: block;
    font-size: 80%;
    line-height: 1.42857;
    color: #999999; }
    blockquote footer:before,
    blockquote small:before,
    blockquote .small:before {
      content: '\2014 \00A0'; }

.blockquote-reverse,
blockquote.pull-right {
  padding-right: 15px;
  padding-left: 0;
  border-right: 5px solid #eeeeee;
  border-left: 0;
  text-align: right; }
  .blockquote-reverse footer:before,
  .blockquote-reverse small:before,
  .blockquote-reverse .small:before,
  blockquote.pull-right footer:before,
  blockquote.pull-right small:before,
  blockquote.pull-right .small:before {
    content: ''; }
  .blockquote-reverse footer:after,
  .blockquote-reverse small:after,
  .blockquote-reverse .small:after,
  blockquote.pull-right footer:after,
  blockquote.pull-right small:after,
  blockquote.pull-right .small:after {
    content: '\00A0 \2014'; }

blockquote:before,
blockquote:after {
  content: ""; }

address {
  margin-bottom: 20px;
  font-style: normal;
  line-height: 1.42857; }

code,
kbd,
pre,
samp {
  font-family: Menlo, Monaco, Consolas, "Courier New", monospace; }

code {
  padding: 2px 4px;
  font-size: 90%;
  color: #c7254e;
  background-color: #f9f2f4;
  border-radius: 4px; }

kbd {
  padding: 2px 4px;
  font-size: 90%;
  color: white;
  background-color: #333333;
  border-radius: 3px;
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25); }

pre {
  display: block;
  padding: 9.5px;
  margin: 0 0 10px;
  font-size: 13px;
  line-height: 1.42857;
  word-break: break-all;
  word-wrap: break-word;
  color: #333333;
  background-color: whitesmoke;
  border: 1px solid #cccccc;
  border-radius: 4px; }
  pre code {
    padding: 0;
    font-size: inherit;
    color: inherit;
    white-space: pre-wrap;
    background-color: transparent;
    border-radius: 0; }

.pre-scrollable {
  max-height: 340px;
  overflow-y: scroll; }

.container {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px; }
  .container:before, .container:after {
    content: " ";
    display: table; }
  .container:after {
    clear: both; }
  @media (min-width: 768px) {
    .container {
      width: 750px; } }
  @media (min-width: 992px) {
    .container {
      width: 970px; } }
  @media (min-width: 1200px) {
    .container {
      width: 1170px; } }

.container-fluid {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px; }
  .container-fluid:before, .container-fluid:after {
    content: " ";
    display: table; }
  .container-fluid:after {
    clear: both; }

.row {
  margin-left: -15px;
  margin-right: -15px; }
  .row:before, .row:after {
    content: " ";
    display: table; }
  .row:after {
    clear: both; }

.col-xs-1, .col-sm-1, .col-md-1, .col-lg-1, .col-xs-2, .col-sm-2, .col-md-2, .col-lg-2, .col-xs-3, .col-sm-3, .col-md-3, .col-lg-3, .col-xs-4, .col-sm-4, .col-md-4, .col-lg-4, .col-xs-5, .col-sm-5, .col-md-5, .col-lg-5, .col-xs-6, .col-sm-6, .col-md-6, .col-lg-6, .col-xs-7, .col-sm-7, .col-md-7, .col-lg-7, .col-xs-8, .col-sm-8, .col-md-8, .col-lg-8, .col-xs-9, .col-sm-9, .col-md-9, .col-lg-9, .col-xs-10, .col-sm-10, .col-md-10, .col-lg-10, .col-xs-11, .col-sm-11, .col-md-11, .col-lg-11, .col-xs-12, .col-sm-12, .col-md-12, .col-lg-12 {
  position: relative;
  min-height: 1px;
  padding-left: 15px;
  padding-right: 15px; }

.col-xs-1, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9, .col-xs-10, .col-xs-11, .col-xs-12 {
  float: left; }

.col-xs-1 {
  width: 8.33333%; }

.col-xs-2 {
  width: 16.66667%; }

.col-xs-3 {
  width: 25%; }

.col-xs-4 {
  width: 33.33333%; }

.col-xs-5 {
  width: 41.66667%; }

.col-xs-6 {
  width: 50%; }

.col-xs-7 {
  width: 58.33333%; }

.col-xs-8 {
  width: 66.66667%; }

.col-xs-9 {
  width: 75%; }

.col-xs-10 {
  width: 83.33333%; }

.col-xs-11 {
  width: 91.66667%; }

.col-xs-12 {
  width: 100%; }

.col-xs-pull-0 {
  right: auto; }

.col-xs-pull-1 {
  right: 8.33333%; }

.col-xs-pull-2 {
  right: 16.66667%; }

.col-xs-pull-3 {
  right: 25%; }

.col-xs-pull-4 {
  right: 33.33333%; }

.col-xs-pull-5 {
  right: 41.66667%; }

.col-xs-pull-6 {
  right: 50%; }

.col-xs-pull-7 {
  right: 58.33333%; }

.col-xs-pull-8 {
  right: 66.66667%; }

.col-xs-pull-9 {
  right: 75%; }

.col-xs-pull-10 {
  right: 83.33333%; }

.col-xs-pull-11 {
  right: 91.66667%; }

.col-xs-pull-12 {
  right: 100%; }

.col-xs-push-0 {
  left: auto; }

.col-xs-push-1 {
  left: 8.33333%; }

.col-xs-push-2 {
  left: 16.66667%; }

.col-xs-push-3 {
  left: 25%; }

.col-xs-push-4 {
  left: 33.33333%; }

.col-xs-push-5 {
  left: 41.66667%; }

.col-xs-push-6 {
  left: 50%; }

.col-xs-push-7 {
  left: 58.33333%; }

.col-xs-push-8 {
  left: 66.66667%; }

.col-xs-push-9 {
  left: 75%; }

.col-xs-push-10 {
  left: 83.33333%; }

.col-xs-push-11 {
  left: 91.66667%; }

.col-xs-push-12 {
  left: 100%; }

.col-xs-offset-0 {
  margin-left: 0%; }

.col-xs-offset-1 {
  margin-left: 8.33333%; }

.col-xs-offset-2 {
  margin-left: 16.66667%; }

.col-xs-offset-3 {
  margin-left: 25%; }

.col-xs-offset-4 {
  margin-left: 33.33333%; }

.col-xs-offset-5 {
  margin-left: 41.66667%; }

.col-xs-offset-6 {
  margin-left: 50%; }

.col-xs-offset-7 {
  margin-left: 58.33333%; }

.col-xs-offset-8 {
  margin-left: 66.66667%; }

.col-xs-offset-9 {
  margin-left: 75%; }

.col-xs-offset-10 {
  margin-left: 83.33333%; }

.col-xs-offset-11 {
  margin-left: 91.66667%; }

.col-xs-offset-12 {
  margin-left: 100%; }

@media (min-width: 768px) {
  .col-sm-1, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-10, .col-sm-11, .col-sm-12 {
    float: left; }

  .col-sm-1 {
    width: 8.33333%; }

  .col-sm-2 {
    width: 16.66667%; }

  .col-sm-3 {
    width: 25%; }

  .col-sm-4 {
    width: 33.33333%; }

  .col-sm-5 {
    width: 41.66667%; }

  .col-sm-6 {
    width: 50%; }

  .col-sm-7 {
    width: 58.33333%; }

  .col-sm-8 {
    width: 66.66667%; }

  .col-sm-9 {
    width: 75%; }

  .col-sm-10 {
    width: 83.33333%; }

  .col-sm-11 {
    width: 91.66667%; }

  .col-sm-12 {
    width: 100%; }

  .col-sm-pull-0 {
    right: auto; }

  .col-sm-pull-1 {
    right: 8.33333%; }

  .col-sm-pull-2 {
    right: 16.66667%; }

  .col-sm-pull-3 {
    right: 25%; }

  .col-sm-pull-4 {
    right: 33.33333%; }

  .col-sm-pull-5 {
    right: 41.66667%; }

  .col-sm-pull-6 {
    right: 50%; }

  .col-sm-pull-7 {
    right: 58.33333%; }

  .col-sm-pull-8 {
    right: 66.66667%; }

  .col-sm-pull-9 {
    right: 75%; }

  .col-sm-pull-10 {
    right: 83.33333%; }

  .col-sm-pull-11 {
    right: 91.66667%; }

  .col-sm-pull-12 {
    right: 100%; }

  .col-sm-push-0 {
    left: auto; }

  .col-sm-push-1 {
    left: 8.33333%; }

  .col-sm-push-2 {
    left: 16.66667%; }

  .col-sm-push-3 {
    left: 25%; }

  .col-sm-push-4 {
    left: 33.33333%; }

  .col-sm-push-5 {
    left: 41.66667%; }

  .col-sm-push-6 {
    left: 50%; }

  .col-sm-push-7 {
    left: 58.33333%; }

  .col-sm-push-8 {
    left: 66.66667%; }

  .col-sm-push-9 {
    left: 75%; }

  .col-sm-push-10 {
    left: 83.33333%; }

  .col-sm-push-11 {
    left: 91.66667%; }

  .col-sm-push-12 {
    left: 100%; }

  .col-sm-offset-0 {
    margin-left: 0%; }

  .col-sm-offset-1 {
    margin-left: 8.33333%; }

  .col-sm-offset-2 {
    margin-left: 16.66667%; }

  .col-sm-offset-3 {
    margin-left: 25%; }

  .col-sm-offset-4 {
    margin-left: 33.33333%; }

  .col-sm-offset-5 {
    margin-left: 41.66667%; }

  .col-sm-offset-6 {
    margin-left: 50%; }

  .col-sm-offset-7 {
    margin-left: 58.33333%; }

  .col-sm-offset-8 {
    margin-left: 66.66667%; }

  .col-sm-offset-9 {
    margin-left: 75%; }

  .col-sm-offset-10 {
    margin-left: 83.33333%; }

  .col-sm-offset-11 {
    margin-left: 91.66667%; }

  .col-sm-offset-12 {
    margin-left: 100%; } }
@media (min-width: 992px) {
  .col-md-1, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-10, .col-md-11, .col-md-12 {
    float: left; }

  .col-md-1 {
    width: 8.33333%; }

  .col-md-2 {
    width: 16.66667%; }

  .col-md-3 {
    width: 25%; }

  .col-md-4 {
    width: 33.33333%; }

  .col-md-5 {
    width: 41.66667%; }

  .col-md-6 {
    width: 50%; }

  .col-md-7 {
    width: 58.33333%; }

  .col-md-8 {
    width: 66.66667%; }

  .col-md-9 {
    width: 75%; }

  .col-md-10 {
    width: 83.33333%; }

  .col-md-11 {
    width: 91.66667%; }

  .col-md-12 {
    width: 100%; }

  .col-md-pull-0 {
    right: auto; }

  .col-md-pull-1 {
    right: 8.33333%; }

  .col-md-pull-2 {
    right: 16.66667%; }

  .col-md-pull-3 {
    right: 25%; }

  .col-md-pull-4 {
    right: 33.33333%; }

  .col-md-pull-5 {
    right: 41.66667%; }

  .col-md-pull-6 {
    right: 50%; }

  .col-md-pull-7 {
    right: 58.33333%; }

  .col-md-pull-8 {
    right: 66.66667%; }

  .col-md-pull-9 {
    right: 75%; }

  .col-md-pull-10 {
    right: 83.33333%; }

  .col-md-pull-11 {
    right: 91.66667%; }

  .col-md-pull-12 {
    right: 100%; }

  .col-md-push-0 {
    left: auto; }

  .col-md-push-1 {
    left: 8.33333%; }

  .col-md-push-2 {
    left: 16.66667%; }

  .col-md-push-3 {
    left: 25%; }

  .col-md-push-4 {
    left: 33.33333%; }

  .col-md-push-5 {
    left: 41.66667%; }

  .col-md-push-6 {
    left: 50%; }

  .col-md-push-7 {
    left: 58.33333%; }

  .col-md-push-8 {
    left: 66.66667%; }

  .col-md-push-9 {
    left: 75%; }

  .col-md-push-10 {
    left: 83.33333%; }

  .col-md-push-11 {
    left: 91.66667%; }

  .col-md-push-12 {
    left: 100%; }

  .col-md-offset-0 {
    margin-left: 0%; }

  .col-md-offset-1 {
    margin-left: 8.33333%; }

  .col-md-offset-2 {
    margin-left: 16.66667%; }

  .col-md-offset-3 {
    margin-left: 25%; }

  .col-md-offset-4 {
    margin-left: 33.33333%; }

  .col-md-offset-5 {
    margin-left: 41.66667%; }

  .col-md-offset-6 {
    margin-left: 50%; }

  .col-md-offset-7 {
    margin-left: 58.33333%; }

  .col-md-offset-8 {
    margin-left: 66.66667%; }

  .col-md-offset-9 {
    margin-left: 75%; }

  .col-md-offset-10 {
    margin-left: 83.33333%; }

  .col-md-offset-11 {
    margin-left: 91.66667%; }

  .col-md-offset-12 {
    margin-left: 100%; } }
@media (min-width: 1200px) {
  .col-lg-1, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-10, .col-lg-11, .col-lg-12 {
    float: left; }

  .col-lg-1 {
    width: 8.33333%; }

  .col-lg-2 {
    width: 16.66667%; }

  .col-lg-3 {
    width: 25%; }

  .col-lg-4 {
    width: 33.33333%; }

  .col-lg-5 {
    width: 41.66667%; }

  .col-lg-6 {
    width: 50%; }

  .col-lg-7 {
    width: 58.33333%; }

  .col-lg-8 {
    width: 66.66667%; }

  .col-lg-9 {
    width: 75%; }

  .col-lg-10 {
    width: 83.33333%; }

  .col-lg-11 {
    width: 91.66667%; }

  .col-lg-12 {
    width: 100%; }

  .col-lg-pull-0 {
    right: auto; }

  .col-lg-pull-1 {
    right: 8.33333%; }

  .col-lg-pull-2 {
    right: 16.66667%; }

  .col-lg-pull-3 {
    right: 25%; }

  .col-lg-pull-4 {
    right: 33.33333%; }

  .col-lg-pull-5 {
    right: 41.66667%; }

  .col-lg-pull-6 {
    right: 50%; }

  .col-lg-pull-7 {
    right: 58.33333%; }

  .col-lg-pull-8 {
    right: 66.66667%; }

  .col-lg-pull-9 {
    right: 75%; }

  .col-lg-pull-10 {
    right: 83.33333%; }

  .col-lg-pull-11 {
    right: 91.66667%; }

  .col-lg-pull-12 {
    right: 100%; }

  .col-lg-push-0 {
    left: auto; }

  .col-lg-push-1 {
    left: 8.33333%; }

  .col-lg-push-2 {
    left: 16.66667%; }

  .col-lg-push-3 {
    left: 25%; }

  .col-lg-push-4 {
    left: 33.33333%; }

  .col-lg-push-5 {
    left: 41.66667%; }

  .col-lg-push-6 {
    left: 50%; }

  .col-lg-push-7 {
    left: 58.33333%; }

  .col-lg-push-8 {
    left: 66.66667%; }

  .col-lg-push-9 {
    left: 75%; }

  .col-lg-push-10 {
    left: 83.33333%; }

  .col-lg-push-11 {
    left: 91.66667%; }

  .col-lg-push-12 {
    left: 100%; }

  .col-lg-offset-0 {
    margin-left: 0%; }

  .col-lg-offset-1 {
    margin-left: 8.33333%; }

  .col-lg-offset-2 {
    margin-left: 16.66667%; }

  .col-lg-offset-3 {
    margin-left: 25%; }

  .col-lg-offset-4 {
    margin-left: 33.33333%; }

  .col-lg-offset-5 {
    margin-left: 41.66667%; }

  .col-lg-offset-6 {
    margin-left: 50%; }

  .col-lg-offset-7 {
    margin-left: 58.33333%; }

  .col-lg-offset-8 {
    margin-left: 66.66667%; }

  .col-lg-offset-9 {
    margin-left: 75%; }

  .col-lg-offset-10 {
    margin-left: 83.33333%; }

  .col-lg-offset-11 {
    margin-left: 91.66667%; }

  .col-lg-offset-12 {
    margin-left: 100%; } }
table {
  max-width: 100%;
  background-color: transparent; }

th {
  text-align: left; }

.table {
  width: 100%;
  margin-bottom: 20px; }
  .table > thead > tr > th,
  .table > thead > tr > td,
  .table > tbody > tr > th,
  .table > tbody > tr > td,
  .table > tfoot > tr > th,
  .table > tfoot > tr > td {
    padding: 8px;
    line-height: 1.42857;
    vertical-align: top;
    border-top: 1px solid #dddddd; }
  .table > thead > tr > th {
    vertical-align: bottom;
    border-bottom: 2px solid #dddddd; }
  .table > caption + thead > tr:first-child > th,
  .table > caption + thead > tr:first-child > td,
  .table > colgroup + thead > tr:first-child > th,
  .table > colgroup + thead > tr:first-child > td,
  .table > thead:first-child > tr:first-child > th,
  .table > thead:first-child > tr:first-child > td {
    border-top: 0; }
  .table > tbody + tbody {
    border-top: 2px solid #dddddd; }
  .table .table {
    background-color: white; }

.table-condensed > thead > tr > th,
.table-condensed > thead > tr > td,
.table-condensed > tbody > tr > th,
.table-condensed > tbody > tr > td,
.table-condensed > tfoot > tr > th,
.table-condensed > tfoot > tr > td {
  padding: 5px; }

.table-bordered {
  border: 1px solid #dddddd; }
  .table-bordered > thead > tr > th,
  .table-bordered > thead > tr > td,
  .table-bordered > tbody > tr > th,
  .table-bordered > tbody > tr > td,
  .table-bordered > tfoot > tr > th,
  .table-bordered > tfoot > tr > td {
    border: 1px solid #dddddd; }
  .table-bordered > thead > tr > th,
  .table-bordered > thead > tr > td {
    border-bottom-width: 2px; }

.table-striped > tbody > tr:nth-child(odd) > td,
.table-striped > tbody > tr:nth-child(odd) > th {
  background-color: #f9f9f9; }

.table-hover > tbody > tr:hover > td,
.table-hover > tbody > tr:hover > th {
  background-color: whitesmoke; }

table col[class*="col-"] {
  position: static;
  float: none;
  display: table-column; }

table td[class*="col-"],
table th[class*="col-"] {
  position: static;
  float: none;
  display: table-cell; }

.table > thead > tr > td.active,
.table > thead > tr > th.active, .table > thead > tr.active > td, .table > thead > tr.active > th,
.table > tbody > tr > td.active,
.table > tbody > tr > th.active,
.table > tbody > tr.active > td,
.table > tbody > tr.active > th,
.table > tfoot > tr > td.active,
.table > tfoot > tr > th.active,
.table > tfoot > tr.active > td,
.table > tfoot > tr.active > th {
  background-color: whitesmoke; }

.table-hover > tbody > tr > td.active:hover,
.table-hover > tbody > tr > th.active:hover, .table-hover > tbody > tr.active:hover > td, .table-hover > tbody > tr:hover > .active, .table-hover > tbody > tr.active:hover > th {
  background-color: #e8e8e8; }

.table > thead > tr > td.success,
.table > thead > tr > th.success, .table > thead > tr.success > td, .table > thead > tr.success > th,
.table > tbody > tr > td.success,
.table > tbody > tr > th.success,
.table > tbody > tr.success > td,
.table > tbody > tr.success > th,
.table > tfoot > tr > td.success,
.table > tfoot > tr > th.success,
.table > tfoot > tr.success > td,
.table > tfoot > tr.success > th {
  background-color: #dff0d8; }

.table-hover > tbody > tr > td.success:hover,
.table-hover > tbody > tr > th.success:hover, .table-hover > tbody > tr.success:hover > td, .table-hover > tbody > tr:hover > .success, .table-hover > tbody > tr.success:hover > th {
  background-color: #d0e9c6; }

.table > thead > tr > td.info,
.table > thead > tr > th.info, .table > thead > tr.info > td, .table > thead > tr.info > th,
.table > tbody > tr > td.info,
.table > tbody > tr > th.info,
.table > tbody > tr.info > td,
.table > tbody > tr.info > th,
.table > tfoot > tr > td.info,
.table > tfoot > tr > th.info,
.table > tfoot > tr.info > td,
.table > tfoot > tr.info > th {
  background-color: #d9edf7; }

.table-hover > tbody > tr > td.info:hover,
.table-hover > tbody > tr > th.info:hover, .table-hover > tbody > tr.info:hover > td, .table-hover > tbody > tr:hover > .info, .table-hover > tbody > tr.info:hover > th {
  background-color: #c4e3f3; }

.table > thead > tr > td.warning,
.table > thead > tr > th.warning, .table > thead > tr.warning > td, .table > thead > tr.warning > th,
.table > tbody > tr > td.warning,
.table > tbody > tr > th.warning,
.table > tbody > tr.warning > td,
.table > tbody > tr.warning > th,
.table > tfoot > tr > td.warning,
.table > tfoot > tr > th.warning,
.table > tfoot > tr.warning > td,
.table > tfoot > tr.warning > th {
  background-color: #fcf8e3; }

.table-hover > tbody > tr > td.warning:hover,
.table-hover > tbody > tr > th.warning:hover, .table-hover > tbody > tr.warning:hover > td, .table-hover > tbody > tr:hover > .warning, .table-hover > tbody > tr.warning:hover > th {
  background-color: #faf2cc; }

.table > thead > tr > td.danger,
.table > thead > tr > th.danger, .table > thead > tr.danger > td, .table > thead > tr.danger > th,
.table > tbody > tr > td.danger,
.table > tbody > tr > th.danger,
.table > tbody > tr.danger > td,
.table > tbody > tr.danger > th,
.table > tfoot > tr > td.danger,
.table > tfoot > tr > th.danger,
.table > tfoot > tr.danger > td,
.table > tfoot > tr.danger > th {
  background-color: #f2dede; }

.table-hover > tbody > tr > td.danger:hover,
.table-hover > tbody > tr > th.danger:hover, .table-hover > tbody > tr.danger:hover > td, .table-hover > tbody > tr:hover > .danger, .table-hover > tbody > tr.danger:hover > th {
  background-color: #ebcccc; }

@media screen and (max-width: 767px) {
  .table-responsive {
    width: 100%;
    margin-bottom: 15px;
    overflow-y: hidden;
    overflow-x: scroll;
    -ms-overflow-style: -ms-autohiding-scrollbar;
    border: 1px solid #dddddd;
    -webkit-overflow-scrolling: touch; }
    .table-responsive > .table {
      margin-bottom: 0; }
      .table-responsive > .table > thead > tr > th,
      .table-responsive > .table > thead > tr > td,
      .table-responsive > .table > tbody > tr > th,
      .table-responsive > .table > tbody > tr > td,
      .table-responsive > .table > tfoot > tr > th,
      .table-responsive > .table > tfoot > tr > td {
        white-space: nowrap; }
    .table-responsive > .table-bordered {
      border: 0; }
      .table-responsive > .table-bordered > thead > tr > th:first-child,
      .table-responsive > .table-bordered > thead > tr > td:first-child,
      .table-responsive > .table-bordered > tbody > tr > th:first-child,
      .table-responsive > .table-bordered > tbody > tr > td:first-child,
      .table-responsive > .table-bordered > tfoot > tr > th:first-child,
      .table-responsive > .table-bordered > tfoot > tr > td:first-child {
        border-left: 0; }
      .table-responsive > .table-bordered > thead > tr > th:last-child,
      .table-responsive > .table-bordered > thead > tr > td:last-child,
      .table-responsive > .table-bordered > tbody > tr > th:last-child,
      .table-responsive > .table-bordered > tbody > tr > td:last-child,
      .table-responsive > .table-bordered > tfoot > tr > th:last-child,
      .table-responsive > .table-bordered > tfoot > tr > td:last-child {
        border-right: 0; }
      .table-responsive > .table-bordered > tbody > tr:last-child > th,
      .table-responsive > .table-bordered > tbody > tr:last-child > td,
      .table-responsive > .table-bordered > tfoot > tr:last-child > th,
      .table-responsive > .table-bordered > tfoot > tr:last-child > td {
        border-bottom: 0; } }

fieldset {
  padding: 0;
  margin: 0;
  border: 0;
  min-width: 0; }

legend {
  display: block;
  width: 100%;
  padding: 0;
  margin-bottom: 20px;
  font-size: 21px;
  line-height: inherit;
  color: #333333;
  border: 0;
  border-bottom: 1px solid #e5e5e5; }

label {
  display: inline-block;
  max-width: 100%;
  margin-bottom: 5px;
  font-weight: bold; }

input[type="search"] {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

input[type="radio"],
input[type="checkbox"] {
  margin: 4px 0 0;
  margin-top: 1px \9;
  line-height: normal; }

input[type="file"] {
  display: block; }

input[type="range"] {
  display: block;
  width: 100%; }

select[multiple],
select[size] {
  height: auto; }

input[type="file"]:focus,
input[type="radio"]:focus,
input[type="checkbox"]:focus {
  outline: thin dotted;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px; }

output {
  display: block;
  padding-top: 7px;
  font-size: 14px;
  line-height: 1.42857;
  color: #555555; }

.form-control {
  display: block;
  width: 100%;
  height: 34px;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857;
  color: #555555;
  background-color: white;
  background-image: none;
  border: 1px solid #cccccc;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
  -o-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
  transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; }
  .form-control:focus {
    border-color: #66afe9;
    outline: 0;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6); }
  .form-control::-moz-placeholder {
    color: #999999;
    opacity: 1; }
  .form-control:-ms-input-placeholder {
    color: #999999; }
  .form-control::-webkit-input-placeholder {
    color: #999999; }
  .form-control[disabled], .form-control[readonly], fieldset[disabled] .form-control {
    cursor: not-allowed;
    background-color: #eeeeee;
    opacity: 1; }

textarea.form-control {
  height: auto; }

input[type="search"] {
  -webkit-appearance: none; }

input[type="date"],
input[type="time"],
input[type="datetime-local"],
input[type="month"] {
  line-height: 34px;
  line-height: 1.42857 \0; }
  input[type="date"].input-sm, .input-group-sm > input[type="date"].form-control,
  .input-group-sm > input[type="date"].input-group-addon,
  .input-group-sm > .input-group-btn > input[type="date"].btn,
  input[type="time"].input-sm,
  .input-group-sm > input[type="time"].form-control,
  .input-group-sm > input[type="time"].input-group-addon,
  .input-group-sm > .input-group-btn > input[type="time"].btn,
  input[type="datetime-local"].input-sm,
  .input-group-sm > input[type="datetime-local"].form-control,
  .input-group-sm > input[type="datetime-local"].input-group-addon,
  .input-group-sm > .input-group-btn > input[type="datetime-local"].btn,
  input[type="month"].input-sm,
  .input-group-sm > input[type="month"].form-control,
  .input-group-sm > input[type="month"].input-group-addon,
  .input-group-sm > .input-group-btn > input[type="month"].btn {
    line-height: 30px; }
  input[type="date"].input-lg, .input-group-lg > input[type="date"].form-control,
  .input-group-lg > input[type="date"].input-group-addon,
  .input-group-lg > .input-group-btn > input[type="date"].btn,
  input[type="time"].input-lg,
  .input-group-lg > input[type="time"].form-control,
  .input-group-lg > input[type="time"].input-group-addon,
  .input-group-lg > .input-group-btn > input[type="time"].btn,
  input[type="datetime-local"].input-lg,
  .input-group-lg > input[type="datetime-local"].form-control,
  .input-group-lg > input[type="datetime-local"].input-group-addon,
  .input-group-lg > .input-group-btn > input[type="datetime-local"].btn,
  input[type="month"].input-lg,
  .input-group-lg > input[type="month"].form-control,
  .input-group-lg > input[type="month"].input-group-addon,
  .input-group-lg > .input-group-btn > input[type="month"].btn {
    line-height: 46px; }

.form-group {
  margin-bottom: 15px; }

.radio,
.checkbox {
  display: block;
  min-height: 20px;
  margin-top: 10px;
  margin-bottom: 10px; }
  .radio label,
  .checkbox label {
    padding-left: 20px;
    margin-bottom: 0;
    font-weight: normal;
    cursor: pointer; }

.radio input[type="radio"],
.radio-inline input[type="radio"],
.checkbox input[type="checkbox"],
.checkbox-inline input[type="checkbox"] {
  float: left;
  margin-left: -20px; }

.radio + .radio,
.checkbox + .checkbox {
  margin-top: -5px; }

.radio-inline,
.checkbox-inline {
  display: inline-block;
  padding-left: 20px;
  margin-bottom: 0;
  vertical-align: middle;
  font-weight: normal;
  cursor: pointer; }

.radio-inline + .radio-inline,
.checkbox-inline + .checkbox-inline {
  margin-top: 0;
  margin-left: 10px; }

input[type="radio"][disabled], fieldset[disabled] input[type="radio"],
input[type="checkbox"][disabled], fieldset[disabled]
input[type="checkbox"],
.radio[disabled], fieldset[disabled]
.radio,
.radio-inline[disabled], fieldset[disabled]
.radio-inline,
.checkbox[disabled], fieldset[disabled]
.checkbox,
.checkbox-inline[disabled], fieldset[disabled]
.checkbox-inline {
  cursor: not-allowed; }

.input-sm, .input-group-sm > .form-control,
.input-group-sm > .input-group-addon,
.input-group-sm > .input-group-btn > .btn {
  height: 30px;
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

select.input-sm, .input-group-sm > select.form-control,
.input-group-sm > select.input-group-addon,
.input-group-sm > .input-group-btn > select.btn {
  height: 30px;
  line-height: 30px; }

textarea.input-sm, .input-group-sm > textarea.form-control,
.input-group-sm > textarea.input-group-addon,
.input-group-sm > .input-group-btn > textarea.btn,
select[multiple].input-sm,
.input-group-sm > select[multiple].form-control,
.input-group-sm > select[multiple].input-group-addon,
.input-group-sm > .input-group-btn > select[multiple].btn {
  height: auto; }

.input-lg, .input-group-lg > .form-control,
.input-group-lg > .input-group-addon,
.input-group-lg > .input-group-btn > .btn {
  height: 46px;
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

select.input-lg, .input-group-lg > select.form-control,
.input-group-lg > select.input-group-addon,
.input-group-lg > .input-group-btn > select.btn {
  height: 46px;
  line-height: 46px; }

textarea.input-lg, .input-group-lg > textarea.form-control,
.input-group-lg > textarea.input-group-addon,
.input-group-lg > .input-group-btn > textarea.btn,
select[multiple].input-lg,
.input-group-lg > select[multiple].form-control,
.input-group-lg > select[multiple].input-group-addon,
.input-group-lg > .input-group-btn > select[multiple].btn {
  height: auto; }

.has-feedback {
  position: relative; }
  .has-feedback .form-control {
    padding-right: 42.5px; }

.form-control-feedback {
  position: absolute;
  top: 25px;
  right: 0;
  z-index: 2;
  display: block;
  width: 34px;
  height: 34px;
  line-height: 34px;
  text-align: center; }

.input-lg + .form-control-feedback, .input-group-lg > .form-control + .form-control-feedback,
.input-group-lg > .input-group-addon + .form-control-feedback,
.input-group-lg > .input-group-btn > .btn + .form-control-feedback {
  width: 46px;
  height: 46px;
  line-height: 46px; }

.input-sm + .form-control-feedback, .input-group-sm > .form-control + .form-control-feedback,
.input-group-sm > .input-group-addon + .form-control-feedback,
.input-group-sm > .input-group-btn > .btn + .form-control-feedback {
  width: 30px;
  height: 30px;
  line-height: 30px; }

.has-success .help-block,
.has-success .control-label,
.has-success .radio,
.has-success .checkbox,
.has-success .radio-inline,
.has-success .checkbox-inline {
  color: #3c763d; }
.has-success .form-control {
  border-color: #3c763d;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }
  .has-success .form-control:focus {
    border-color: #2b542c;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168; }
.has-success .input-group-addon {
  color: #3c763d;
  border-color: #3c763d;
  background-color: #dff0d8; }
.has-success .form-control-feedback {
  color: #3c763d; }

.has-warning .help-block,
.has-warning .control-label,
.has-warning .radio,
.has-warning .checkbox,
.has-warning .radio-inline,
.has-warning .checkbox-inline {
  color: #8a6d3b; }
.has-warning .form-control {
  border-color: #8a6d3b;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }
  .has-warning .form-control:focus {
    border-color: #66512c;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b; }
.has-warning .input-group-addon {
  color: #8a6d3b;
  border-color: #8a6d3b;
  background-color: #fcf8e3; }
.has-warning .form-control-feedback {
  color: #8a6d3b; }

.has-error .help-block,
.has-error .control-label,
.has-error .radio,
.has-error .checkbox,
.has-error .radio-inline,
.has-error .checkbox-inline {
  color: #a94442; }
.has-error .form-control {
  border-color: #a94442;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }
  .has-error .form-control:focus {
    border-color: #843534;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483; }
.has-error .input-group-addon {
  color: #a94442;
  border-color: #a94442;
  background-color: #f2dede; }
.has-error .form-control-feedback {
  color: #a94442; }

.has-feedback label.sr-only ~ .form-control-feedback {
  top: 0; }

.form-control-static {
  margin-bottom: 0; }

.help-block {
  display: block;
  margin-top: 5px;
  margin-bottom: 10px;
  color: #737373; }

@media (min-width: 768px) {
  .form-inline .form-group, .navbar-form .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle; }
  .form-inline .form-control, .navbar-form .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle; }
  .form-inline .input-group, .navbar-form .input-group {
    display: inline-table;
    vertical-align: middle; }
    .form-inline .input-group .input-group-addon, .navbar-form .input-group .input-group-addon,
    .form-inline .input-group .input-group-btn,
    .navbar-form .input-group .input-group-btn,
    .form-inline .input-group .form-control,
    .navbar-form .input-group .form-control {
      width: auto; }
  .form-inline .input-group > .form-control, .navbar-form .input-group > .form-control {
    width: 100%; }
  .form-inline .control-label, .navbar-form .control-label {
    margin-bottom: 0;
    vertical-align: middle; }
  .form-inline .radio, .navbar-form .radio,
  .form-inline .checkbox,
  .navbar-form .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    padding-left: 0;
    vertical-align: middle; }
  .form-inline .radio input[type="radio"], .navbar-form .radio input[type="radio"],
  .form-inline .checkbox input[type="checkbox"],
  .navbar-form .checkbox input[type="checkbox"] {
    float: none;
    margin-left: 0; }
  .form-inline .has-feedback .form-control-feedback, .navbar-form .has-feedback .form-control-feedback {
    top: 0; } }

.form-horizontal .radio,
.form-horizontal .checkbox,
.form-horizontal .radio-inline,
.form-horizontal .checkbox-inline {
  margin-top: 0;
  margin-bottom: 0;
  padding-top: 7px; }
.form-horizontal .radio,
.form-horizontal .checkbox {
  min-height: 27px; }
.form-horizontal .form-group {
  margin-left: -15px;
  margin-right: -15px; }
  .form-horizontal .form-group:before, .form-horizontal .form-group:after {
    content: " ";
    display: table; }
  .form-horizontal .form-group:after {
    clear: both; }
.form-horizontal .form-control-static {
  padding-top: 7px;
  padding-bottom: 7px; }
@media (min-width: 768px) {
  .form-horizontal .control-label {
    text-align: right;
    margin-bottom: 0;
    padding-top: 7px; } }
.form-horizontal .has-feedback .form-control-feedback {
  top: 0;
  right: 15px; }

.btn {
  display: inline-block;
  margin-bottom: 0;
  font-weight: normal;
  text-align: center;
  vertical-align: middle;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  white-space: nowrap;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857;
  border-radius: 4px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none; }
  .btn:focus, .btn:active:focus, .btn.active:focus {
    outline: thin dotted;
    outline: 5px auto -webkit-focus-ring-color;
    outline-offset: -2px; }
  .btn:hover, .btn:focus {
    color: #333333;
    text-decoration: none; }
  .btn:active, .btn.active {
    outline: 0;
    background-image: none;
    -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
    box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }
  .btn.disabled, .btn[disabled], fieldset[disabled] .btn {
    cursor: not-allowed;
    pointer-events: none;
    opacity: 0.65;
    filter: alpha(opacity=65);
    -webkit-box-shadow: none;
    box-shadow: none; }

.btn-default {
  color: #333333;
  background-color: white;
  border-color: #cccccc; }
  .btn-default:hover, .btn-default:focus, .btn-default:active, .btn-default.active, .open > .btn-default.dropdown-toggle {
    color: #333333;
    background-color: #e6e6e6;
    border-color: #adadad; }
  .btn-default:active, .btn-default.active, .open > .btn-default.dropdown-toggle {
    background-image: none; }
  .btn-default.disabled, .btn-default.disabled:hover, .btn-default.disabled:focus, .btn-default.disabled:active, .btn-default.disabled.active, .btn-default[disabled], .btn-default[disabled]:hover, .btn-default[disabled]:focus, .btn-default[disabled]:active, .btn-default[disabled].active, fieldset[disabled] .btn-default, fieldset[disabled] .btn-default:hover, fieldset[disabled] .btn-default:focus, fieldset[disabled] .btn-default:active, fieldset[disabled] .btn-default.active {
    background-color: white;
    border-color: #cccccc; }
  .btn-default .badge {
    color: white;
    background-color: #333333; }

.btn-primary {
  color: white;
  background-color: #428bca;
  border-color: #357ebd; }
  .btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open > .btn-primary.dropdown-toggle {
    color: white;
    background-color: #3071a9;
    border-color: #285e8e; }
  .btn-primary:active, .btn-primary.active, .open > .btn-primary.dropdown-toggle {
    background-image: none; }
  .btn-primary.disabled, .btn-primary.disabled:hover, .btn-primary.disabled:focus, .btn-primary.disabled:active, .btn-primary.disabled.active, .btn-primary[disabled], .btn-primary[disabled]:hover, .btn-primary[disabled]:focus, .btn-primary[disabled]:active, .btn-primary[disabled].active, fieldset[disabled] .btn-primary, fieldset[disabled] .btn-primary:hover, fieldset[disabled] .btn-primary:focus, fieldset[disabled] .btn-primary:active, fieldset[disabled] .btn-primary.active {
    background-color: #428bca;
    border-color: #357ebd; }
  .btn-primary .badge {
    color: #428bca;
    background-color: white; }

.btn-success {
  color: white;
  background-color: #5cb85c;
  border-color: #4cae4c; }
  .btn-success:hover, .btn-success:focus, .btn-success:active, .btn-success.active, .open > .btn-success.dropdown-toggle {
    color: white;
    background-color: #449d44;
    border-color: #398439; }
  .btn-success:active, .btn-success.active, .open > .btn-success.dropdown-toggle {
    background-image: none; }
  .btn-success.disabled, .btn-success.disabled:hover, .btn-success.disabled:focus, .btn-success.disabled:active, .btn-success.disabled.active, .btn-success[disabled], .btn-success[disabled]:hover, .btn-success[disabled]:focus, .btn-success[disabled]:active, .btn-success[disabled].active, fieldset[disabled] .btn-success, fieldset[disabled] .btn-success:hover, fieldset[disabled] .btn-success:focus, fieldset[disabled] .btn-success:active, fieldset[disabled] .btn-success.active {
    background-color: #5cb85c;
    border-color: #4cae4c; }
  .btn-success .badge {
    color: #5cb85c;
    background-color: white; }

.btn-info {
  color: white;
  background-color: #5bc0de;
  border-color: #46b8da; }
  .btn-info:hover, .btn-info:focus, .btn-info:active, .btn-info.active, .open > .btn-info.dropdown-toggle {
    color: white;
    background-color: #31b0d5;
    border-color: #269abc; }
  .btn-info:active, .btn-info.active, .open > .btn-info.dropdown-toggle {
    background-image: none; }
  .btn-info.disabled, .btn-info.disabled:hover, .btn-info.disabled:focus, .btn-info.disabled:active, .btn-info.disabled.active, .btn-info[disabled], .btn-info[disabled]:hover, .btn-info[disabled]:focus, .btn-info[disabled]:active, .btn-info[disabled].active, fieldset[disabled] .btn-info, fieldset[disabled] .btn-info:hover, fieldset[disabled] .btn-info:focus, fieldset[disabled] .btn-info:active, fieldset[disabled] .btn-info.active {
    background-color: #5bc0de;
    border-color: #46b8da; }
  .btn-info .badge {
    color: #5bc0de;
    background-color: white; }

.btn-warning {
  color: white;
  background-color: #f0ad4e;
  border-color: #eea236; }
  .btn-warning:hover, .btn-warning:focus, .btn-warning:active, .btn-warning.active, .open > .btn-warning.dropdown-toggle {
    color: white;
    background-color: #ec971f;
    border-color: #d58512; }
  .btn-warning:active, .btn-warning.active, .open > .btn-warning.dropdown-toggle {
    background-image: none; }
  .btn-warning.disabled, .btn-warning.disabled:hover, .btn-warning.disabled:focus, .btn-warning.disabled:active, .btn-warning.disabled.active, .btn-warning[disabled], .btn-warning[disabled]:hover, .btn-warning[disabled]:focus, .btn-warning[disabled]:active, .btn-warning[disabled].active, fieldset[disabled] .btn-warning, fieldset[disabled] .btn-warning:hover, fieldset[disabled] .btn-warning:focus, fieldset[disabled] .btn-warning:active, fieldset[disabled] .btn-warning.active {
    background-color: #f0ad4e;
    border-color: #eea236; }
  .btn-warning .badge {
    color: #f0ad4e;
    background-color: white; }

.btn-danger {
  color: white;
  background-color: #d9534f;
  border-color: #d43f3a; }
  .btn-danger:hover, .btn-danger:focus, .btn-danger:active, .btn-danger.active, .open > .btn-danger.dropdown-toggle {
    color: white;
    background-color: #c9302c;
    border-color: #ac2925; }
  .btn-danger:active, .btn-danger.active, .open > .btn-danger.dropdown-toggle {
    background-image: none; }
  .btn-danger.disabled, .btn-danger.disabled:hover, .btn-danger.disabled:focus, .btn-danger.disabled:active, .btn-danger.disabled.active, .btn-danger[disabled], .btn-danger[disabled]:hover, .btn-danger[disabled]:focus, .btn-danger[disabled]:active, .btn-danger[disabled].active, fieldset[disabled] .btn-danger, fieldset[disabled] .btn-danger:hover, fieldset[disabled] .btn-danger:focus, fieldset[disabled] .btn-danger:active, fieldset[disabled] .btn-danger.active {
    background-color: #d9534f;
    border-color: #d43f3a; }
  .btn-danger .badge {
    color: #d9534f;
    background-color: white; }

.btn-link {
  color: #428bca;
  font-weight: normal;
  cursor: pointer;
  border-radius: 0; }
  .btn-link, .btn-link:active, .btn-link[disabled], fieldset[disabled] .btn-link {
    background-color: transparent;
    -webkit-box-shadow: none;
    box-shadow: none; }
  .btn-link, .btn-link:hover, .btn-link:focus, .btn-link:active {
    border-color: transparent; }
  .btn-link:hover, .btn-link:focus {
    color: #2a6496;
    text-decoration: underline;
    background-color: transparent; }
  .btn-link[disabled]:hover, .btn-link[disabled]:focus, fieldset[disabled] .btn-link:hover, fieldset[disabled] .btn-link:focus {
    color: #999999;
    text-decoration: none; }

.btn-lg, .btn-group-lg > .btn {
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

.btn-sm, .btn-group-sm > .btn {
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-xs, .btn-group-xs > .btn {
  padding: 1px 5px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-block {
  display: block;
  width: 100%;
  padding-left: 0;
  padding-right: 0; }

.btn-block + .btn-block {
  margin-top: 5px; }

input[type="submit"].btn-block,
input[type="reset"].btn-block,
input[type="button"].btn-block {
  width: 100%; }

.fade {
  opacity: 0;
  -webkit-transition: opacity 0.15s linear;
  -o-transition: opacity 0.15s linear;
  transition: opacity 0.15s linear; }
  .fade.in {
    opacity: 1; }

.collapse {
  display: none; }
  .collapse.in {
    display: block; }

tr.collapse.in {
  display: table-row; }

tbody.collapse.in {
  display: table-row-group; }

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  -webkit-transition: height 0.35s ease;
  -o-transition: height 0.35s ease;
  transition: height 0.35s ease; }

.caret {
  display: inline-block;
  width: 0;
  height: 0;
  margin-left: 2px;
  vertical-align: middle;
  border-top: 4px solid;
  border-right: 4px solid transparent;
  border-left: 4px solid transparent; }

.dropdown {
  position: relative; }

.dropdown-toggle:focus {
  outline: 0; }

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 160px;
  padding: 5px 0;
  margin: 2px 0 0;
  list-style: none;
  font-size: 14px;
  text-align: left;
  background-color: white;
  border: 1px solid #cccccc;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 4px;
  -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  background-clip: padding-box; }
  .dropdown-menu.pull-right {
    right: 0;
    left: auto; }
  .dropdown-menu .divider {
    height: 1px;
    margin: 9px 0;
    overflow: hidden;
    background-color: #e5e5e5; }
  .dropdown-menu > li > a {
    display: block;
    padding: 3px 20px;
    clear: both;
    font-weight: normal;
    line-height: 1.42857;
    color: #333333;
    white-space: nowrap; }

.dropdown-menu > li > a:hover, .dropdown-menu > li > a:focus {
  text-decoration: none;
  color: #262626;
  background-color: whitesmoke; }

.dropdown-menu > .active > a, .dropdown-menu > .active > a:hover, .dropdown-menu > .active > a:focus {
  color: white;
  text-decoration: none;
  outline: 0;
  background-color: #428bca; }

.dropdown-menu > .disabled > a, .dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  color: #999999; }

.dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  text-decoration: none;
  background-color: transparent;
  background-image: none;
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  cursor: not-allowed; }

.open > .dropdown-menu {
  display: block; }
.open > a {
  outline: 0; }

.dropdown-menu-right {
  left: auto;
  right: 0; }

.dropdown-menu-left {
  left: 0;
  right: auto; }

.dropdown-header {
  display: block;
  padding: 3px 20px;
  font-size: 12px;
  line-height: 1.42857;
  color: #999999; }

.dropdown-backdrop {
  position: fixed;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  z-index: 990; }

.pull-right > .dropdown-menu {
  right: 0;
  left: auto; }

.dropup .caret,
.navbar-fixed-bottom .dropdown .caret {
  border-top: 0;
  border-bottom: 4px solid;
  content: ""; }
.dropup .dropdown-menu,
.navbar-fixed-bottom .dropdown .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-bottom: 1px; }

@media (min-width: 768px) {
  .navbar-right .dropdown-menu {
    right: 0;
    left: auto; }
  .navbar-right .dropdown-menu-left {
    left: 0;
    right: auto; } }
.btn-group,
.btn-group-vertical {
  position: relative;
  display: inline-block;
  vertical-align: middle; }
  .btn-group > .btn,
  .btn-group-vertical > .btn {
    position: relative;
    float: left; }
    .btn-group > .btn:hover, .btn-group > .btn:focus, .btn-group > .btn:active, .btn-group > .btn.active,
    .btn-group-vertical > .btn:hover,
    .btn-group-vertical > .btn:focus,
    .btn-group-vertical > .btn:active,
    .btn-group-vertical > .btn.active {
      z-index: 2; }
    .btn-group > .btn:focus,
    .btn-group-vertical > .btn:focus {
      outline: 0; }

.btn-group .btn + .btn,
.btn-group .btn + .btn-group,
.btn-group .btn-group + .btn,
.btn-group .btn-group + .btn-group {
  margin-left: -1px; }

.btn-toolbar {
  margin-left: -5px; }
  .btn-toolbar:before, .btn-toolbar:after {
    content: " ";
    display: table; }
  .btn-toolbar:after {
    clear: both; }
  .btn-toolbar .btn-group,
  .btn-toolbar .input-group {
    float: left; }
  .btn-toolbar > .btn,
  .btn-toolbar > .btn-group,
  .btn-toolbar > .input-group {
    margin-left: 5px; }

.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
  border-radius: 0; }

.btn-group > .btn:first-child {
  margin-left: 0; }
  .btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle) {
    border-bottom-right-radius: 0;
    border-top-right-radius: 0; }

.btn-group > .btn:last-child:not(:first-child),
.btn-group > .dropdown-toggle:not(:first-child) {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group > .btn-group {
  float: left; }

.btn-group > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group > .btn-group:first-child > .btn:last-child,
.btn-group > .btn-group:first-child > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.btn-group > .btn-group:last-child > .btn:first-child {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group .dropdown-toggle:active,
.btn-group.open .dropdown-toggle {
  outline: 0; }

.btn-group > .btn + .dropdown-toggle {
  padding-left: 8px;
  padding-right: 8px; }

.btn-group > .btn-lg + .dropdown-toggle, .btn-group-lg.btn-group > .btn + .dropdown-toggle {
  padding-left: 12px;
  padding-right: 12px; }

.btn-group.open .dropdown-toggle {
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }
  .btn-group.open .dropdown-toggle.btn-link {
    -webkit-box-shadow: none;
    box-shadow: none; }

.btn .caret {
  margin-left: 0; }

.btn-lg .caret, .btn-group-lg > .btn .caret {
  border-width: 5px 5px 0;
  border-bottom-width: 0; }

.dropup .btn-lg .caret, .dropup .btn-group-lg > .btn .caret {
  border-width: 0 5px 5px; }

.btn-group-vertical > .btn,
.btn-group-vertical > .btn-group,
.btn-group-vertical > .btn-group > .btn {
  display: block;
  float: none;
  width: 100%;
  max-width: 100%; }
.btn-group-vertical > .btn-group:before, .btn-group-vertical > .btn-group:after {
  content: " ";
  display: table; }
.btn-group-vertical > .btn-group:after {
  clear: both; }
.btn-group-vertical > .btn-group > .btn {
  float: none; }
.btn-group-vertical > .btn + .btn,
.btn-group-vertical > .btn + .btn-group,
.btn-group-vertical > .btn-group + .btn,
.btn-group-vertical > .btn-group + .btn-group {
  margin-top: -1px;
  margin-left: 0; }

.btn-group-vertical > .btn:not(:first-child):not(:last-child) {
  border-radius: 0; }
.btn-group-vertical > .btn:first-child:not(:last-child) {
  border-top-right-radius: 4px;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }
.btn-group-vertical > .btn:last-child:not(:first-child) {
  border-bottom-left-radius: 4px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-vertical > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group-vertical > .btn-group:first-child:not(:last-child) > .btn:last-child,
.btn-group-vertical > .btn-group:first-child:not(:last-child) > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.btn-group-vertical > .btn-group:last-child:not(:first-child) > .btn:first-child {
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-justified {
  display: table;
  width: 100%;
  table-layout: fixed;
  border-collapse: separate; }
  .btn-group-justified > .btn,
  .btn-group-justified > .btn-group {
    float: none;
    display: table-cell;
    width: 1%; }
  .btn-group-justified > .btn-group .btn {
    width: 100%; }

[data-toggle="buttons"] > .btn > input[type="radio"],
[data-toggle="buttons"] > .btn > input[type="checkbox"] {
  position: absolute;
  z-index: -1;
  opacity: 0; }

.input-group {
  position: relative;
  display: table;
  border-collapse: separate; }
  .input-group[class*="col-"] {
    float: none;
    padding-left: 0;
    padding-right: 0; }
  .input-group .form-control {
    position: relative;
    z-index: 2;
    float: left;
    width: 100%;
    margin-bottom: 0; }

.input-group-addon,
.input-group-btn,
.input-group .form-control {
  display: table-cell; }
  .input-group-addon:not(:first-child):not(:last-child),
  .input-group-btn:not(:first-child):not(:last-child),
  .input-group .form-control:not(:first-child):not(:last-child) {
    border-radius: 0; }

.input-group-addon,
.input-group-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle; }

.input-group-addon {
  padding: 6px 12px;
  font-size: 14px;
  font-weight: normal;
  line-height: 1;
  color: #555555;
  text-align: center;
  background-color: #eeeeee;
  border: 1px solid #cccccc;
  border-radius: 4px; }
  .input-group-addon.input-sm,
  .input-group-sm > .input-group-addon,
  .input-group-sm > .input-group-btn > .input-group-addon.btn {
    padding: 5px 10px;
    font-size: 12px;
    border-radius: 3px; }
  .input-group-addon.input-lg,
  .input-group-lg > .input-group-addon,
  .input-group-lg > .input-group-btn > .input-group-addon.btn {
    padding: 10px 16px;
    font-size: 18px;
    border-radius: 6px; }
  .input-group-addon input[type="radio"],
  .input-group-addon input[type="checkbox"] {
    margin-top: 0; }

.input-group .form-control:first-child,
.input-group-addon:first-child,
.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .btn-group > .btn,
.input-group-btn:first-child > .dropdown-toggle,
.input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle),
.input-group-btn:last-child > .btn-group:not(:last-child) > .btn {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.input-group-addon:first-child {
  border-right: 0; }

.input-group .form-control:last-child,
.input-group-addon:last-child,
.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .btn-group > .btn,
.input-group-btn:last-child > .dropdown-toggle,
.input-group-btn:first-child > .btn:not(:first-child),
.input-group-btn:first-child > .btn-group:not(:first-child) > .btn {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.input-group-addon:last-child {
  border-left: 0; }

.input-group-btn {
  position: relative;
  font-size: 0;
  white-space: nowrap; }
  .input-group-btn > .btn {
    position: relative; }
    .input-group-btn > .btn + .btn {
      margin-left: -1px; }
    .input-group-btn > .btn:hover, .input-group-btn > .btn:focus, .input-group-btn > .btn:active {
      z-index: 2; }
  .input-group-btn:first-child > .btn,
  .input-group-btn:first-child > .btn-group {
    margin-right: -1px; }
  .input-group-btn:last-child > .btn,
  .input-group-btn:last-child > .btn-group {
    margin-left: -1px; }

.nav {
  margin-bottom: 0;
  padding-left: 0;
  list-style: none; }
  .nav:before, .nav:after {
    content: " ";
    display: table; }
  .nav:after {
    clear: both; }
  .nav > li {
    position: relative;
    display: block; }
    .nav > li > a {
      position: relative;
      display: block;
      padding: 10px 15px; }
      .nav > li > a:hover, .nav > li > a:focus {
        text-decoration: none;
        background-color: #eeeeee; }
    .nav > li.disabled > a {
      color: #999999; }
      .nav > li.disabled > a:hover, .nav > li.disabled > a:focus {
        color: #999999;
        text-decoration: none;
        background-color: transparent;
        cursor: not-allowed; }
  .nav .open > a, .nav .open > a:hover, .nav .open > a:focus {
    background-color: #eeeeee;
    border-color: #428bca; }
  .nav .nav-divider {
    height: 1px;
    margin: 9px 0;
    overflow: hidden;
    background-color: #e5e5e5; }
  .nav > li > a > img {
    max-width: none; }

.nav-tabs {
  border-bottom: 1px solid #dddddd; }
  .nav-tabs > li {
    float: left;
    margin-bottom: -1px; }
    .nav-tabs > li > a {
      margin-right: 2px;
      line-height: 1.42857;
      border: 1px solid transparent;
      border-radius: 4px 4px 0 0; }
      .nav-tabs > li > a:hover {
        border-color: #eeeeee #eeeeee #dddddd; }
    .nav-tabs > li.active > a, .nav-tabs > li.active > a:hover, .nav-tabs > li.active > a:focus {
      color: #555555;
      background-color: white;
      border: 1px solid #dddddd;
      border-bottom-color: transparent;
      cursor: default; }

.nav-pills > li {
  float: left; }
  .nav-pills > li > a {
    border-radius: 4px; }
  .nav-pills > li + li {
    margin-left: 2px; }
  .nav-pills > li.active > a, .nav-pills > li.active > a:hover, .nav-pills > li.active > a:focus {
    color: white;
    background-color: #428bca; }

.nav-stacked > li {
  float: none; }
  .nav-stacked > li + li {
    margin-top: 2px;
    margin-left: 0; }

.nav-justified, .nav-tabs.nav-justified {
  width: 100%; }
  .nav-justified > li, .nav-tabs.nav-justified > li {
    float: none; }
    .nav-justified > li > a, .nav-tabs.nav-justified > li > a {
      text-align: center;
      margin-bottom: 5px; }
  .nav-justified > .dropdown .dropdown-menu {
    top: auto;
    left: auto; }
  @media (min-width: 768px) {
    .nav-justified > li, .nav-tabs.nav-justified > li {
      display: table-cell;
      width: 1%; }
      .nav-justified > li > a, .nav-tabs.nav-justified > li > a {
        margin-bottom: 0; } }

.nav-tabs-justified, .nav-tabs.nav-justified {
  border-bottom: 0; }
  .nav-tabs-justified > li > a, .nav-tabs.nav-justified > li > a {
    margin-right: 0;
    border-radius: 4px; }
  .nav-tabs-justified > .active > a, .nav-tabs.nav-justified > .active > a,
  .nav-tabs-justified > .active > a:hover,
  .nav-tabs.nav-justified > .active > a:hover,
  .nav-tabs-justified > .active > a:focus,
  .nav-tabs.nav-justified > .active > a:focus {
    border: 1px solid #dddddd; }
  @media (min-width: 768px) {
    .nav-tabs-justified > li > a, .nav-tabs.nav-justified > li > a {
      border-bottom: 1px solid #dddddd;
      border-radius: 4px 4px 0 0; }
    .nav-tabs-justified > .active > a, .nav-tabs.nav-justified > .active > a,
    .nav-tabs-justified > .active > a:hover,
    .nav-tabs.nav-justified > .active > a:hover,
    .nav-tabs-justified > .active > a:focus,
    .nav-tabs.nav-justified > .active > a:focus {
      border-bottom-color: white; } }

.tab-content > .tab-pane {
  display: none; }
.tab-content > .active {
  display: block; }

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar {
  position: relative;
  min-height: 50px;
  margin-bottom: 20px;
  border: 1px solid transparent; }
  .navbar:before, .navbar:after {
    content: " ";
    display: table; }
  .navbar:after {
    clear: both; }
  @media (min-width: 768px) {
    .navbar {
      border-radius: 4px; } }

.navbar-header:before, .navbar-header:after {
  content: " ";
  display: table; }
.navbar-header:after {
  clear: both; }
@media (min-width: 768px) {
  .navbar-header {
    float: left; } }

.navbar-collapse {
  overflow-x: visible;
  padding-right: 15px;
  padding-left: 15px;
  border-top: 1px solid transparent;
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  -webkit-overflow-scrolling: touch; }
  .navbar-collapse:before, .navbar-collapse:after {
    content: " ";
    display: table; }
  .navbar-collapse:after {
    clear: both; }
  .navbar-collapse.in {
    overflow-y: auto; }
  @media (min-width: 768px) {
    .navbar-collapse {
      width: auto;
      border-top: 0;
      box-shadow: none; }
      .navbar-collapse.collapse {
        display: block !important;
        height: auto !important;
        padding-bottom: 0;
        overflow: visible !important; }
      .navbar-collapse.in {
        overflow-y: visible; }
      .navbar-fixed-top .navbar-collapse, .navbar-static-top .navbar-collapse, .navbar-fixed-bottom .navbar-collapse {
        padding-left: 0;
        padding-right: 0; } }

.navbar-fixed-top .navbar-collapse,
.navbar-fixed-bottom .navbar-collapse {
  max-height: 340px; }
  @media (max-width: 480px) and (orientation: landscape) {
    .navbar-fixed-top .navbar-collapse,
    .navbar-fixed-bottom .navbar-collapse {
      max-height: 200px; } }

.container > .navbar-header,
.container > .navbar-collapse,
.container-fluid > .navbar-header,
.container-fluid > .navbar-collapse {
  margin-right: -15px;
  margin-left: -15px; }
  @media (min-width: 768px) {
    .container > .navbar-header,
    .container > .navbar-collapse,
    .container-fluid > .navbar-header,
    .container-fluid > .navbar-collapse {
      margin-right: 0;
      margin-left: 0; } }

.navbar-static-top {
  z-index: 1000;
  border-width: 0 0 1px; }
  @media (min-width: 768px) {
    .navbar-static-top {
      border-radius: 0; } }

.navbar-fixed-top,
.navbar-fixed-bottom {
  position: fixed;
  right: 0;
  left: 0;
  z-index: 1030; }
  @media (min-width: 768px) {
    .navbar-fixed-top,
    .navbar-fixed-bottom {
      border-radius: 0; } }

.navbar-fixed-top {
  top: 0;
  border-width: 0 0 1px; }

.navbar-fixed-bottom {
  bottom: 0;
  margin-bottom: 0;
  border-width: 1px 0 0; }

.navbar-brand {
  float: left;
  padding: 15px 15px;
  font-size: 18px;
  line-height: 20px;
  height: 50px; }
  .navbar-brand:hover, .navbar-brand:focus {
    text-decoration: none; }
  @media (min-width: 768px) {
    .navbar > .container .navbar-brand, .navbar > .container-fluid .navbar-brand {
      margin-left: -15px; } }

.navbar-toggle {
  position: relative;
  float: right;
  margin-right: 15px;
  padding: 9px 10px;
  margin-top: 8px;
  margin-bottom: 8px;
  background-color: transparent;
  background-image: none;
  border: 1px solid transparent;
  border-radius: 4px; }
  .navbar-toggle:focus {
    outline: 0; }
  .navbar-toggle .icon-bar {
    display: block;
    width: 22px;
    height: 2px;
    border-radius: 1px; }
  .navbar-toggle .icon-bar + .icon-bar {
    margin-top: 4px; }
  @media (min-width: 768px) {
    .navbar-toggle {
      display: none; } }

.navbar-nav {
  margin: 7.5px -15px; }
  .navbar-nav > li > a {
    padding-top: 10px;
    padding-bottom: 10px;
    line-height: 20px; }
  @media (max-width: 767px) {
    .navbar-nav .open .dropdown-menu {
      position: static;
      float: none;
      width: auto;
      margin-top: 0;
      background-color: transparent;
      border: 0;
      box-shadow: none; }
      .navbar-nav .open .dropdown-menu > li > a,
      .navbar-nav .open .dropdown-menu .dropdown-header {
        padding: 5px 15px 5px 25px; }
      .navbar-nav .open .dropdown-menu > li > a {
        line-height: 20px; }
        .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-nav .open .dropdown-menu > li > a:focus {
          background-image: none; } }
  @media (min-width: 768px) {
    .navbar-nav {
      float: left;
      margin: 0; }
      .navbar-nav > li {
        float: left; }
        .navbar-nav > li > a {
          padding-top: 15px;
          padding-bottom: 15px; }
      .navbar-nav.navbar-right:last-child {
        margin-right: -15px; } }

@media (min-width: 768px) {
  .navbar-left {
    float: left !important; }

  .navbar-right {
    float: right !important; } }
.navbar-form {
  margin-left: -15px;
  margin-right: -15px;
  padding: 10px 15px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  margin-top: 8px;
  margin-bottom: 8px; }
  @media (max-width: 767px) {
    .navbar-form .form-group {
      margin-bottom: 5px; } }
  @media (min-width: 768px) {
    .navbar-form {
      width: auto;
      border: 0;
      margin-left: 0;
      margin-right: 0;
      padding-top: 0;
      padding-bottom: 0;
      -webkit-box-shadow: none;
      box-shadow: none; }
      .navbar-form.navbar-right:last-child {
        margin-right: -15px; } }

.navbar-nav > li > .dropdown-menu {
  margin-top: 0;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.navbar-btn {
  margin-top: 8px;
  margin-bottom: 8px; }
  .navbar-btn.btn-sm, .btn-group-sm > .navbar-btn.btn {
    margin-top: 10px;
    margin-bottom: 10px; }
  .navbar-btn.btn-xs, .btn-group-xs > .navbar-btn.btn {
    margin-top: 14px;
    margin-bottom: 14px; }

.navbar-text {
  margin-top: 15px;
  margin-bottom: 15px; }
  @media (min-width: 768px) {
    .navbar-text {
      float: left;
      margin-left: 15px;
      margin-right: 15px; }
      .navbar-text.navbar-right:last-child {
        margin-right: 0; } }

.navbar-default {
  background-color: #f8f8f8;
  border-color: #e7e7e7; }
  .navbar-default .navbar-brand {
    color: #777777; }
    .navbar-default .navbar-brand:hover, .navbar-default .navbar-brand:focus {
      color: #5e5e5e;
      background-color: transparent; }
  .navbar-default .navbar-text {
    color: #777777; }
  .navbar-default .navbar-nav > li > a {
    color: #777777; }
    .navbar-default .navbar-nav > li > a:hover, .navbar-default .navbar-nav > li > a:focus {
      color: #333333;
      background-color: transparent; }
  .navbar-default .navbar-nav > .active > a, .navbar-default .navbar-nav > .active > a:hover, .navbar-default .navbar-nav > .active > a:focus {
    color: #555555;
    background-color: #e7e7e7; }
  .navbar-default .navbar-nav > .disabled > a, .navbar-default .navbar-nav > .disabled > a:hover, .navbar-default .navbar-nav > .disabled > a:focus {
    color: #cccccc;
    background-color: transparent; }
  .navbar-default .navbar-toggle {
    border-color: #dddddd; }
    .navbar-default .navbar-toggle:hover, .navbar-default .navbar-toggle:focus {
      background-color: #dddddd; }
    .navbar-default .navbar-toggle .icon-bar {
      background-color: #888888; }
  .navbar-default .navbar-collapse,
  .navbar-default .navbar-form {
    border-color: #e7e7e7; }
  .navbar-default .navbar-nav > .open > a, .navbar-default .navbar-nav > .open > a:hover, .navbar-default .navbar-nav > .open > a:focus {
    background-color: #e7e7e7;
    color: #555555; }
  @media (max-width: 767px) {
    .navbar-default .navbar-nav .open .dropdown-menu > li > a {
      color: #777777; }
      .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
        color: #333333;
        background-color: transparent; }
    .navbar-default .navbar-nav .open .dropdown-menu > .active > a, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus {
      color: #555555;
      background-color: #e7e7e7; }
    .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus {
      color: #cccccc;
      background-color: transparent; } }
  .navbar-default .navbar-link {
    color: #777777; }
    .navbar-default .navbar-link:hover {
      color: #333333; }
  .navbar-default .btn-link {
    color: #777777; }
    .navbar-default .btn-link:hover, .navbar-default .btn-link:focus {
      color: #333333; }
    .navbar-default .btn-link[disabled]:hover, .navbar-default .btn-link[disabled]:focus, fieldset[disabled] .navbar-default .btn-link:hover, fieldset[disabled] .navbar-default .btn-link:focus {
      color: #cccccc; }

.navbar-inverse {
  background-color: #222222;
  border-color: #090909; }
  .navbar-inverse .navbar-brand {
    color: #999999; }
    .navbar-inverse .navbar-brand:hover, .navbar-inverse .navbar-brand:focus {
      color: white;
      background-color: transparent; }
  .navbar-inverse .navbar-text {
    color: #999999; }
  .navbar-inverse .navbar-nav > li > a {
    color: #999999; }
    .navbar-inverse .navbar-nav > li > a:hover, .navbar-inverse .navbar-nav > li > a:focus {
      color: white;
      background-color: transparent; }
  .navbar-inverse .navbar-nav > .active > a, .navbar-inverse .navbar-nav > .active > a:hover, .navbar-inverse .navbar-nav > .active > a:focus {
    color: white;
    background-color: #090909; }
  .navbar-inverse .navbar-nav > .disabled > a, .navbar-inverse .navbar-nav > .disabled > a:hover, .navbar-inverse .navbar-nav > .disabled > a:focus {
    color: #444444;
    background-color: transparent; }
  .navbar-inverse .navbar-toggle {
    border-color: #333333; }
    .navbar-inverse .navbar-toggle:hover, .navbar-inverse .navbar-toggle:focus {
      background-color: #333333; }
    .navbar-inverse .navbar-toggle .icon-bar {
      background-color: white; }
  .navbar-inverse .navbar-collapse,
  .navbar-inverse .navbar-form {
    border-color: #101010; }
  .navbar-inverse .navbar-nav > .open > a, .navbar-inverse .navbar-nav > .open > a:hover, .navbar-inverse .navbar-nav > .open > a:focus {
    background-color: #090909;
    color: white; }
  @media (max-width: 767px) {
    .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
      border-color: #090909; }
    .navbar-inverse .navbar-nav .open .dropdown-menu .divider {
      background-color: #090909; }
    .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
      color: #999999; }
      .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus {
        color: white;
        background-color: transparent; }
    .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus {
      color: white;
      background-color: #090909; }
    .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus {
      color: #444444;
      background-color: transparent; } }
  .navbar-inverse .navbar-link {
    color: #999999; }
    .navbar-inverse .navbar-link:hover {
      color: white; }
  .navbar-inverse .btn-link {
    color: #999999; }
    .navbar-inverse .btn-link:hover, .navbar-inverse .btn-link:focus {
      color: white; }
    .navbar-inverse .btn-link[disabled]:hover, .navbar-inverse .btn-link[disabled]:focus, fieldset[disabled] .navbar-inverse .btn-link:hover, fieldset[disabled] .navbar-inverse .btn-link:focus {
      color: #444444; }

.breadcrumb {
  padding: 8px 15px;
  margin-bottom: 20px;
  list-style: none;
  background-color: whitesmoke;
  border-radius: 4px; }
  .breadcrumb > li {
    display: inline-block; }
    .breadcrumb > li + li:before {
      content: "/\00a0";
      padding: 0 5px;
      color: #cccccc; }
  .breadcrumb > .active {
    color: #999999; }

.pagination {
  display: inline-block;
  padding-left: 0;
  margin: 20px 0;
  border-radius: 4px; }
  .pagination > li {
    display: inline; }
    .pagination > li > a,
    .pagination > li > span {
      position: relative;
      float: left;
      padding: 6px 12px;
      line-height: 1.42857;
      text-decoration: none;
      color: #428bca;
      background-color: white;
      border: 1px solid #dddddd;
      margin-left: -1px; }
    .pagination > li:first-child > a,
    .pagination > li:first-child > span {
      margin-left: 0;
      border-bottom-left-radius: 4px;
      border-top-left-radius: 4px; }
    .pagination > li:last-child > a,
    .pagination > li:last-child > span {
      border-bottom-right-radius: 4px;
      border-top-right-radius: 4px; }
  .pagination > li > a:hover, .pagination > li > a:focus,
  .pagination > li > span:hover,
  .pagination > li > span:focus {
    color: #2a6496;
    background-color: #eeeeee;
    border-color: #dddddd; }
  .pagination > .active > a, .pagination > .active > a:hover, .pagination > .active > a:focus,
  .pagination > .active > span,
  .pagination > .active > span:hover,
  .pagination > .active > span:focus {
    z-index: 2;
    color: white;
    background-color: #428bca;
    border-color: #428bca;
    cursor: default; }
  .pagination > .disabled > span,
  .pagination > .disabled > span:hover,
  .pagination > .disabled > span:focus,
  .pagination > .disabled > a,
  .pagination > .disabled > a:hover,
  .pagination > .disabled > a:focus {
    color: #999999;
    background-color: white;
    border-color: #dddddd;
    cursor: not-allowed; }

.pagination-lg > li > a,
.pagination-lg > li > span {
  padding: 10px 16px;
  font-size: 18px; }
.pagination-lg > li:first-child > a,
.pagination-lg > li:first-child > span {
  border-bottom-left-radius: 6px;
  border-top-left-radius: 6px; }
.pagination-lg > li:last-child > a,
.pagination-lg > li:last-child > span {
  border-bottom-right-radius: 6px;
  border-top-right-radius: 6px; }

.pagination-sm > li > a,
.pagination-sm > li > span {
  padding: 5px 10px;
  font-size: 12px; }
.pagination-sm > li:first-child > a,
.pagination-sm > li:first-child > span {
  border-bottom-left-radius: 3px;
  border-top-left-radius: 3px; }
.pagination-sm > li:last-child > a,
.pagination-sm > li:last-child > span {
  border-bottom-right-radius: 3px;
  border-top-right-radius: 3px; }

.pager {
  padding-left: 0;
  margin: 20px 0;
  list-style: none;
  text-align: center; }
  .pager:before, .pager:after {
    content: " ";
    display: table; }
  .pager:after {
    clear: both; }
  .pager li {
    display: inline; }
    .pager li > a,
    .pager li > span {
      display: inline-block;
      padding: 5px 14px;
      background-color: white;
      border: 1px solid #dddddd;
      border-radius: 15px; }
    .pager li > a:hover,
    .pager li > a:focus {
      text-decoration: none;
      background-color: #eeeeee; }
  .pager .next > a,
  .pager .next > span {
    float: right; }
  .pager .previous > a,
  .pager .previous > span {
    float: left; }
  .pager .disabled > a,
  .pager .disabled > a:hover,
  .pager .disabled > a:focus,
  .pager .disabled > span {
    color: #999999;
    background-color: white;
    cursor: not-allowed; }

.label {
  display: inline;
  padding: .2em .6em .3em;
  font-size: 75%;
  font-weight: bold;
  line-height: 1;
  color: white;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em; }
  .label:empty {
    display: none; }
  .btn .label {
    position: relative;
    top: -1px; }

a.label:hover, a.label:focus {
  color: white;
  text-decoration: none;
  cursor: pointer; }

.label-default {
  background-color: #999999; }
  .label-default[href]:hover, .label-default[href]:focus {
    background-color: gray; }

.label-primary {
  background-color: #428bca; }
  .label-primary[href]:hover, .label-primary[href]:focus {
    background-color: #3071a9; }

.label-success {
  background-color: #5cb85c; }
  .label-success[href]:hover, .label-success[href]:focus {
    background-color: #449d44; }

.label-info {
  background-color: #5bc0de; }
  .label-info[href]:hover, .label-info[href]:focus {
    background-color: #31b0d5; }

.label-warning {
  background-color: #f0ad4e; }
  .label-warning[href]:hover, .label-warning[href]:focus {
    background-color: #ec971f; }

.label-danger {
  background-color: #d9534f; }
  .label-danger[href]:hover, .label-danger[href]:focus {
    background-color: #c9302c; }

.badge {
  display: inline-block;
  min-width: 10px;
  padding: 3px 7px;
  font-size: 12px;
  font-weight: bold;
  color: white;
  line-height: 1;
  vertical-align: baseline;
  white-space: nowrap;
  text-align: center;
  background-color: #999999;
  border-radius: 10px; }
  .badge:empty {
    display: none; }
  .btn .badge {
    position: relative;
    top: -1px; }
  .btn-xs .badge, .btn-group-xs > .btn .badge {
    top: 0;
    padding: 1px 5px; }
  a.list-group-item.active > .badge, .nav-pills > .active > a > .badge {
    color: #428bca;
    background-color: white; }
  .nav-pills > li > a > .badge {
    margin-left: 3px; }

a.badge:hover, a.badge:focus {
  color: white;
  text-decoration: none;
  cursor: pointer; }

.jumbotron {
  padding: 30px;
  margin-bottom: 30px;
  color: inherit;
  background-color: #eeeeee; }
  .jumbotron h1,
  .jumbotron .h1 {
    color: inherit; }
  .jumbotron p {
    margin-bottom: 15px;
    font-size: 21px;
    font-weight: 200; }
  .jumbotron > hr {
    border-top-color: #d5d5d5; }
  .container .jumbotron {
    border-radius: 6px; }
  .jumbotron .container {
    max-width: 100%; }
  @media screen and (min-width: 768px) {
    .jumbotron {
      padding-top: 48px;
      padding-bottom: 48px; }
      .container .jumbotron {
        padding-left: 60px;
        padding-right: 60px; }
      .jumbotron h1,
      .jumbotron .h1 {
        font-size: 63px; } }

.thumbnail {
  display: block;
  padding: 4px;
  margin-bottom: 20px;
  line-height: 1.42857;
  background-color: white;
  border: 1px solid #dddddd;
  border-radius: 4px;
  -webkit-transition: all 0.2s ease-in-out;
  -o-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out; }
  .thumbnail > img,
  .thumbnail a > img {
    display: block;
    max-width: 100%;
    height: auto;
    margin-left: auto;
    margin-right: auto; }
  .thumbnail .caption {
    padding: 9px;
    color: #333333; }

a.thumbnail:hover,
a.thumbnail:focus,
a.thumbnail.active {
  border-color: #428bca; }

.alert {
  padding: 15px;
  margin-bottom: 20px;
  border: 1px solid transparent;
  border-radius: 4px; }
  .alert h4 {
    margin-top: 0;
    color: inherit; }
  .alert .alert-link {
    font-weight: bold; }
  .alert > p,
  .alert > ul {
    margin-bottom: 0; }
  .alert > p + p {
    margin-top: 5px; }

.alert-dismissable {
  padding-right: 35px; }
  .alert-dismissable .close {
    position: relative;
    top: -2px;
    right: -21px;
    color: inherit; }

.alert-success {
  background-color: #dff0d8;
  border-color: #d6e9c6;
  color: #3c763d; }
  .alert-success hr {
    border-top-color: #c9e2b3; }
  .alert-success .alert-link {
    color: #2b542c; }

.alert-info {
  background-color: #d9edf7;
  border-color: #bce8f1;
  color: #31708f; }
  .alert-info hr {
    border-top-color: #a6e1ec; }
  .alert-info .alert-link {
    color: #245269; }

.alert-warning {
  background-color: #fcf8e3;
  border-color: #faebcc;
  color: #8a6d3b; }
  .alert-warning hr {
    border-top-color: #f7e1b5; }
  .alert-warning .alert-link {
    color: #66512c; }

.alert-danger {
  background-color: #f2dede;
  border-color: #ebccd1;
  color: #a94442; }
  .alert-danger hr {
    border-top-color: #e4b9c0; }
  .alert-danger .alert-link {
    color: #843534; }

@keyframes progress-bar-stripes {
  from {
    background-position: 40px 0; }

  to {
    background-position: 0 0; } }
.progress {
  overflow: hidden;
  height: 20px;
  margin-bottom: 20px;
  background-color: whitesmoke;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
  box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1); }

.progress-bar {
  float: left;
  width: 0%;
  height: 100%;
  font-size: 12px;
  line-height: 20px;
  color: white;
  text-align: center;
  background-color: #428bca;
  -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  -webkit-transition: width 0.6s ease;
  -o-transition: width 0.6s ease;
  transition: width 0.6s ease; }

.progress-striped .progress-bar {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -o-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-size: 40px 40px; }

.progress.active .progress-bar {
  -webkit-animation: progress-bar-stripes 2s linear infinite;
  -o-animation: progress-bar-stripes 2s linear infinite;
  animation: progress-bar-stripes 2s linear infinite; }

.progress-bar[aria-valuenow="1"], .progress-bar[aria-valuenow="2"] {
  min-width: 30px; }
.progress-bar[aria-valuenow="0"] {
  color: #999999;
  min-width: 30px;
  background-color: transparent;
  background-image: none;
  box-shadow: none; }

.progress-bar-success {
  background-color: #5cb85c; }
  .progress-striped .progress-bar-success {
    background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: -o-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-info {
  background-color: #5bc0de; }
  .progress-striped .progress-bar-info {
    background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: -o-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-warning {
  background-color: #f0ad4e; }
  .progress-striped .progress-bar-warning {
    background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: -o-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-danger {
  background-color: #d9534f; }
  .progress-striped .progress-bar-danger {
    background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: -o-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
    background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.media,
.media-body {
  overflow: hidden;
  zoom: 1; }

.media,
.media .media {
  margin-top: 15px; }

.media:first-child {
  margin-top: 0; }

.media-object {
  display: block; }

.media-heading {
  margin: 0 0 5px; }

.media > .pull-left {
  margin-right: 10px; }
.media > .pull-right {
  margin-left: 10px; }

.media-list {
  padding-left: 0;
  list-style: none; }

.list-group {
  margin-bottom: 20px;
  padding-left: 0; }

.list-group-item {
  position: relative;
  display: block;
  padding: 10px 15px;
  margin-bottom: -1px;
  background-color: white;
  border: 1px solid #dddddd; }
  .list-group-item:first-child {
    border-top-right-radius: 4px;
    border-top-left-radius: 4px; }
  .list-group-item:last-child {
    margin-bottom: 0;
    border-bottom-right-radius: 4px;
    border-bottom-left-radius: 4px; }
  .list-group-item > .badge {
    float: right; }
  .list-group-item > .badge + .badge {
    margin-right: 5px; }

a.list-group-item {
  color: #555555; }
  a.list-group-item .list-group-item-heading {
    color: #333333; }
  a.list-group-item:hover, a.list-group-item:focus {
    text-decoration: none;
    color: #555555;
    background-color: whitesmoke; }

.list-group-item.disabled, .list-group-item.disabled:hover, .list-group-item.disabled:focus {
  background-color: #eeeeee;
  color: #999999; }
  .list-group-item.disabled .list-group-item-heading, .list-group-item.disabled:hover .list-group-item-heading, .list-group-item.disabled:focus .list-group-item-heading {
    color: inherit; }
  .list-group-item.disabled .list-group-item-text, .list-group-item.disabled:hover .list-group-item-text, .list-group-item.disabled:focus .list-group-item-text {
    color: #999999; }
.list-group-item.active, .list-group-item.active:hover, .list-group-item.active:focus {
  z-index: 2;
  color: white;
  background-color: #428bca;
  border-color: #428bca; }
  .list-group-item.active .list-group-item-heading, .list-group-item.active:hover .list-group-item-heading, .list-group-item.active:focus .list-group-item-heading {
    color: inherit; }
  .list-group-item.active .list-group-item-text, .list-group-item.active:hover .list-group-item-text, .list-group-item.active:focus .list-group-item-text {
    color: #e1edf7; }

.list-group-item-success {
  color: #3c763d;
  background-color: #dff0d8; }

a.list-group-item-success {
  color: #3c763d; }
  a.list-group-item-success .list-group-item-heading {
    color: inherit; }
  a.list-group-item-success:hover, a.list-group-item-success:focus {
    color: #3c763d;
    background-color: #d0e9c6; }
  a.list-group-item-success.active, a.list-group-item-success.active:hover, a.list-group-item-success.active:focus {
    color: #fff;
    background-color: #3c763d;
    border-color: #3c763d; }

.list-group-item-info {
  color: #31708f;
  background-color: #d9edf7; }

a.list-group-item-info {
  color: #31708f; }
  a.list-group-item-info .list-group-item-heading {
    color: inherit; }
  a.list-group-item-info:hover, a.list-group-item-info:focus {
    color: #31708f;
    background-color: #c4e3f3; }
  a.list-group-item-info.active, a.list-group-item-info.active:hover, a.list-group-item-info.active:focus {
    color: #fff;
    background-color: #31708f;
    border-color: #31708f; }

.list-group-item-warning {
  color: #8a6d3b;
  background-color: #fcf8e3; }

a.list-group-item-warning {
  color: #8a6d3b; }
  a.list-group-item-warning .list-group-item-heading {
    color: inherit; }
  a.list-group-item-warning:hover, a.list-group-item-warning:focus {
    color: #8a6d3b;
    background-color: #faf2cc; }
  a.list-group-item-warning.active, a.list-group-item-warning.active:hover, a.list-group-item-warning.active:focus {
    color: #fff;
    background-color: #8a6d3b;
    border-color: #8a6d3b; }

.list-group-item-danger {
  color: #a94442;
  background-color: #f2dede; }

a.list-group-item-danger {
  color: #a94442; }
  a.list-group-item-danger .list-group-item-heading {
    color: inherit; }
  a.list-group-item-danger:hover, a.list-group-item-danger:focus {
    color: #a94442;
    background-color: #ebcccc; }
  a.list-group-item-danger.active, a.list-group-item-danger.active:hover, a.list-group-item-danger.active:focus {
    color: #fff;
    background-color: #a94442;
    border-color: #a94442; }

.list-group-item-heading {
  margin-top: 0;
  margin-bottom: 5px; }

.list-group-item-text {
  margin-bottom: 0;
  line-height: 1.3; }

.panel {
  margin-bottom: 20px;
  background-color: white;
  border: 1px solid transparent;
  border-radius: 4px;
  -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05); }

.panel-body {
  padding: 15px; }
  .panel-body:before, .panel-body:after {
    content: " ";
    display: table; }
  .panel-body:after {
    clear: both; }

.panel-heading {
  padding: 10px 15px;
  border-bottom: 1px solid transparent;
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }
  .panel-heading > .dropdown .dropdown-toggle {
    color: inherit; }

.panel-title {
  margin-top: 0;
  margin-bottom: 0;
  font-size: 16px;
  color: inherit; }
  .panel-title > a {
    color: inherit; }

.panel-footer {
  padding: 10px 15px;
  background-color: whitesmoke;
  border-top: 1px solid #dddddd;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel > .list-group {
  margin-bottom: 0; }
  .panel > .list-group .list-group-item {
    border-width: 1px 0;
    border-radius: 0; }
  .panel > .list-group:first-child .list-group-item:first-child {
    border-top: 0;
    border-top-right-radius: 3px;
    border-top-left-radius: 3px; }
  .panel > .list-group:last-child .list-group-item:last-child {
    border-bottom: 0;
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px; }

.panel-heading + .list-group .list-group-item:first-child {
  border-top-width: 0; }

.panel > .table,
.panel > .table-responsive > .table {
  margin-bottom: 0; }
.panel > .table:first-child,
.panel > .table-responsive:first-child > .table:first-child {
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }
  .panel > .table:first-child > thead:first-child > tr:first-child td:first-child,
  .panel > .table:first-child > thead:first-child > tr:first-child th:first-child,
  .panel > .table:first-child > tbody:first-child > tr:first-child td:first-child,
  .panel > .table:first-child > tbody:first-child > tr:first-child th:first-child,
  .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:first-child,
  .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:first-child,
  .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:first-child,
  .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:first-child {
    border-top-left-radius: 3px; }
  .panel > .table:first-child > thead:first-child > tr:first-child td:last-child,
  .panel > .table:first-child > thead:first-child > tr:first-child th:last-child,
  .panel > .table:first-child > tbody:first-child > tr:first-child td:last-child,
  .panel > .table:first-child > tbody:first-child > tr:first-child th:last-child,
  .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:last-child,
  .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:last-child,
  .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:last-child,
  .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:last-child {
    border-top-right-radius: 3px; }
.panel > .table:last-child,
.panel > .table-responsive:last-child > .table:last-child {
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }
  .panel > .table:last-child > tbody:last-child > tr:last-child td:first-child,
  .panel > .table:last-child > tbody:last-child > tr:last-child th:first-child,
  .panel > .table:last-child > tfoot:last-child > tr:last-child td:first-child,
  .panel > .table:last-child > tfoot:last-child > tr:last-child th:first-child,
  .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:first-child,
  .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:first-child,
  .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:first-child,
  .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:first-child {
    border-bottom-left-radius: 3px; }
  .panel > .table:last-child > tbody:last-child > tr:last-child td:last-child,
  .panel > .table:last-child > tbody:last-child > tr:last-child th:last-child,
  .panel > .table:last-child > tfoot:last-child > tr:last-child td:last-child,
  .panel > .table:last-child > tfoot:last-child > tr:last-child th:last-child,
  .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:last-child,
  .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:last-child,
  .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:last-child,
  .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:last-child {
    border-bottom-right-radius: 3px; }
.panel > .panel-body + .table,
.panel > .panel-body + .table-responsive {
  border-top: 1px solid #dddddd; }
.panel > .table > tbody:first-child > tr:first-child th,
.panel > .table > tbody:first-child > tr:first-child td {
  border-top: 0; }
.panel > .table-bordered,
.panel > .table-responsive > .table-bordered {
  border: 0; }
  .panel > .table-bordered > thead > tr > th:first-child,
  .panel > .table-bordered > thead > tr > td:first-child,
  .panel > .table-bordered > tbody > tr > th:first-child,
  .panel > .table-bordered > tbody > tr > td:first-child,
  .panel > .table-bordered > tfoot > tr > th:first-child,
  .panel > .table-bordered > tfoot > tr > td:first-child,
  .panel > .table-responsive > .table-bordered > thead > tr > th:first-child,
  .panel > .table-responsive > .table-bordered > thead > tr > td:first-child,
  .panel > .table-responsive > .table-bordered > tbody > tr > th:first-child,
  .panel > .table-responsive > .table-bordered > tbody > tr > td:first-child,
  .panel > .table-responsive > .table-bordered > tfoot > tr > th:first-child,
  .panel > .table-responsive > .table-bordered > tfoot > tr > td:first-child {
    border-left: 0; }
  .panel > .table-bordered > thead > tr > th:last-child,
  .panel > .table-bordered > thead > tr > td:last-child,
  .panel > .table-bordered > tbody > tr > th:last-child,
  .panel > .table-bordered > tbody > tr > td:last-child,
  .panel > .table-bordered > tfoot > tr > th:last-child,
  .panel > .table-bordered > tfoot > tr > td:last-child,
  .panel > .table-responsive > .table-bordered > thead > tr > th:last-child,
  .panel > .table-responsive > .table-bordered > thead > tr > td:last-child,
  .panel > .table-responsive > .table-bordered > tbody > tr > th:last-child,
  .panel > .table-responsive > .table-bordered > tbody > tr > td:last-child,
  .panel > .table-responsive > .table-bordered > tfoot > tr > th:last-child,
  .panel > .table-responsive > .table-bordered > tfoot > tr > td:last-child {
    border-right: 0; }
  .panel > .table-bordered > thead > tr:first-child > td,
  .panel > .table-bordered > thead > tr:first-child > th,
  .panel > .table-bordered > tbody > tr:first-child > td,
  .panel > .table-bordered > tbody > tr:first-child > th,
  .panel > .table-responsive > .table-bordered > thead > tr:first-child > td,
  .panel > .table-responsive > .table-bordered > thead > tr:first-child > th,
  .panel > .table-responsive > .table-bordered > tbody > tr:first-child > td,
  .panel > .table-responsive > .table-bordered > tbody > tr:first-child > th {
    border-bottom: 0; }
  .panel > .table-bordered > tbody > tr:last-child > td,
  .panel > .table-bordered > tbody > tr:last-child > th,
  .panel > .table-bordered > tfoot > tr:last-child > td,
  .panel > .table-bordered > tfoot > tr:last-child > th,
  .panel > .table-responsive > .table-bordered > tbody > tr:last-child > td,
  .panel > .table-responsive > .table-bordered > tbody > tr:last-child > th,
  .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > td,
  .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > th {
    border-bottom: 0; }
.panel > .table-responsive {
  border: 0;
  margin-bottom: 0; }

.panel-group {
  margin-bottom: 20px; }
  .panel-group .panel {
    margin-bottom: 0;
    border-radius: 4px; }
    .panel-group .panel + .panel {
      margin-top: 5px; }
  .panel-group .panel-heading {
    border-bottom: 0; }
    .panel-group .panel-heading + .panel-collapse .panel-body {
      border-top: 1px solid #dddddd; }
  .panel-group .panel-footer {
    border-top: 0; }
    .panel-group .panel-footer + .panel-collapse .panel-body {
      border-bottom: 1px solid #dddddd; }

.panel-default {
  border-color: #dddddd; }
  .panel-default > .panel-heading {
    color: #333333;
    background-color: whitesmoke;
    border-color: #dddddd; }
    .panel-default > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #dddddd; }
  .panel-default > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #dddddd; }

.panel-primary {
  border-color: #428bca; }
  .panel-primary > .panel-heading {
    color: white;
    background-color: #428bca;
    border-color: #428bca; }
    .panel-primary > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #428bca; }
  .panel-primary > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #428bca; }

.panel-success {
  border-color: #d6e9c6; }
  .panel-success > .panel-heading {
    color: #3c763d;
    background-color: #dff0d8;
    border-color: #d6e9c6; }
    .panel-success > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #d6e9c6; }
  .panel-success > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #d6e9c6; }

.panel-info {
  border-color: #bce8f1; }
  .panel-info > .panel-heading {
    color: #31708f;
    background-color: #d9edf7;
    border-color: #bce8f1; }
    .panel-info > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #bce8f1; }
  .panel-info > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #bce8f1; }

.panel-warning {
  border-color: #faebcc; }
  .panel-warning > .panel-heading {
    color: #8a6d3b;
    background-color: #fcf8e3;
    border-color: #faebcc; }
    .panel-warning > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #faebcc; }
  .panel-warning > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #faebcc; }

.panel-danger {
  border-color: #ebccd1; }
  .panel-danger > .panel-heading {
    color: #a94442;
    background-color: #f2dede;
    border-color: #ebccd1; }
    .panel-danger > .panel-heading + .panel-collapse > .panel-body {
      border-top-color: #ebccd1; }
  .panel-danger > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #ebccd1; }

.embed-responsive {
  position: relative;
  display: block;
  height: 0;
  padding: 0;
  overflow: hidden; }
  .embed-responsive .embed-responsive-item,
  .embed-responsive iframe,
  .embed-responsive embed,
  .embed-responsive object {
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    height: 100%;
    width: 100%;
    border: 0; }
  .embed-responsive.embed-responsive-16by9 {
    padding-bottom: 56.25%; }
  .embed-responsive.embed-responsive-4by3 {
    padding-bottom: 75%; }

.well {
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: whitesmoke;
  border: 1px solid #e3e3e3;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05); }
  .well blockquote {
    border-color: #ddd;
    border-color: rgba(0, 0, 0, 0.15); }

.well-lg {
  padding: 24px;
  border-radius: 6px; }

.well-sm {
  padding: 9px;
  border-radius: 3px; }

.close {
  float: right;
  font-size: 21px;
  font-weight: bold;
  line-height: 1;
  color: black;
  text-shadow: 0 1px 0 white;
  opacity: 0.2;
  filter: alpha(opacity=20); }
  .close:hover, .close:focus {
    color: black;
    text-decoration: none;
    cursor: pointer;
    opacity: 0.5;
    filter: alpha(opacity=50); }

button.close {
  padding: 0;
  cursor: pointer;
  background: transparent;
  border: 0;
  -webkit-appearance: none; }

.modal-open {
  overflow: hidden; }

.modal {
  display: none;
  overflow: auto;
  overflow-y: scroll;
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1050;
  -webkit-overflow-scrolling: touch;
  outline: 0; }
  .modal.fade .modal-dialog {
    -webkit-transform: translate(0, -25%);
    -ms-transform: translate(0, -25%);
    -o-transform: translate(0, -25%);
    transform: translate(0, -25%);
    -webkit-transition: -webkit-transform 0.3s ease-out;
    -moz-transition: -moz-transform 0.3s ease-out;
    -o-transition: -o-transform 0.3s ease-out;
    transition: transform 0.3s ease-out; }
  .modal.in .modal-dialog {
    -webkit-transform: translate(0, 0);
    -ms-transform: translate(0, 0);
    -o-transform: translate(0, 0);
    transform: translate(0, 0); }

.modal-dialog {
  position: relative;
  width: auto;
  margin: 10px; }

.modal-content {
  position: relative;
  background-color: white;
  border: 1px solid #999999;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  background-clip: padding-box;
  outline: 0; }

.modal-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1040;
  background-color: black; }
  .modal-backdrop.fade {
    opacity: 0;
    filter: alpha(opacity=0); }
  .modal-backdrop.in {
    opacity: 0.5;
    filter: alpha(opacity=50); }

.modal-header {
  padding: 15px;
  border-bottom: 1px solid #e5e5e5;
  min-height: 16.42857px; }

.modal-header .close {
  margin-top: -2px; }

.modal-title {
  margin: 0;
  line-height: 1.42857; }

.modal-body {
  position: relative;
  padding: 15px; }

.modal-footer {
  padding: 15px;
  text-align: right;
  border-top: 1px solid #e5e5e5; }
  .modal-footer:before, .modal-footer:after {
    content: " ";
    display: table; }
  .modal-footer:after {
    clear: both; }
  .modal-footer .btn + .btn {
    margin-left: 5px;
    margin-bottom: 0; }
  .modal-footer .btn-group .btn + .btn {
    margin-left: -1px; }
  .modal-footer .btn-block + .btn-block {
    margin-left: 0; }

.modal-scrollbar-measure {
  position: absolute;
  top: -9999px;
  width: 50px;
  height: 50px;
  overflow: scroll; }

@media (min-width: 768px) {
  .modal-dialog {
    width: 600px;
    margin: 30px auto; }

  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5); }

  .modal-sm {
    width: 300px; } }
@media (min-width: 992px) {
  .modal-lg {
    width: 900px; } }
.tooltip {
  position: absolute;
  z-index: 1070;
  display: block;
  visibility: visible;
  font-size: 12px;
  line-height: 1.4;
  opacity: 0;
  filter: alpha(opacity=0); }
  .tooltip.in {
    opacity: 0.9;
    filter: alpha(opacity=90); }
  .tooltip.top {
    margin-top: -3px;
    padding: 5px 0; }
  .tooltip.right {
    margin-left: 3px;
    padding: 0 5px; }
  .tooltip.bottom {
    margin-top: 3px;
    padding: 5px 0; }
  .tooltip.left {
    margin-left: -3px;
    padding: 0 5px; }

.tooltip-inner {
  max-width: 200px;
  padding: 3px 8px;
  color: white;
  text-align: center;
  text-decoration: none;
  background-color: black;
  border-radius: 4px; }

.tooltip-arrow {
  position: absolute;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.tooltip.top .tooltip-arrow {
  bottom: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 5px 5px 0;
  border-top-color: black; }
.tooltip.top-left .tooltip-arrow {
  bottom: 0;
  left: 5px;
  border-width: 5px 5px 0;
  border-top-color: black; }
.tooltip.top-right .tooltip-arrow {
  bottom: 0;
  right: 5px;
  border-width: 5px 5px 0;
  border-top-color: black; }
.tooltip.right .tooltip-arrow {
  top: 50%;
  left: 0;
  margin-top: -5px;
  border-width: 5px 5px 5px 0;
  border-right-color: black; }
.tooltip.left .tooltip-arrow {
  top: 50%;
  right: 0;
  margin-top: -5px;
  border-width: 5px 0 5px 5px;
  border-left-color: black; }
.tooltip.bottom .tooltip-arrow {
  top: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: black; }
.tooltip.bottom-left .tooltip-arrow {
  top: 0;
  left: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: black; }
.tooltip.bottom-right .tooltip-arrow {
  top: 0;
  right: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: black; }

.popover {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 1060;
  display: none;
  max-width: 276px;
  padding: 1px;
  text-align: left;
  background-color: white;
  background-clip: padding-box;
  border: 1px solid #cccccc;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  white-space: normal; }
  .popover.top {
    margin-top: -10px; }
  .popover.right {
    margin-left: 10px; }
  .popover.bottom {
    margin-top: 10px; }
  .popover.left {
    margin-left: -10px; }

.popover-title {
  margin: 0;
  padding: 8px 14px;
  font-size: 14px;
  font-weight: normal;
  line-height: 18px;
  background-color: #f7f7f7;
  border-bottom: 1px solid #ebebeb;
  border-radius: 5px 5px 0 0; }

.popover-content {
  padding: 9px 14px; }

.popover > .arrow, .popover > .arrow:after {
  position: absolute;
  display: block;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.popover > .arrow {
  border-width: 11px; }

.popover > .arrow:after {
  border-width: 10px;
  content: ""; }

.popover.top > .arrow {
  left: 50%;
  margin-left: -11px;
  border-bottom-width: 0;
  border-top-color: #999999;
  border-top-color: rgba(0, 0, 0, 0.25);
  bottom: -11px; }
  .popover.top > .arrow:after {
    content: " ";
    bottom: 1px;
    margin-left: -10px;
    border-bottom-width: 0;
    border-top-color: white; }
.popover.right > .arrow {
  top: 50%;
  left: -11px;
  margin-top: -11px;
  border-left-width: 0;
  border-right-color: #999999;
  border-right-color: rgba(0, 0, 0, 0.25); }
  .popover.right > .arrow:after {
    content: " ";
    left: 1px;
    bottom: -10px;
    border-left-width: 0;
    border-right-color: white; }
.popover.bottom > .arrow {
  left: 50%;
  margin-left: -11px;
  border-top-width: 0;
  border-bottom-color: #999999;
  border-bottom-color: rgba(0, 0, 0, 0.25);
  top: -11px; }
  .popover.bottom > .arrow:after {
    content: " ";
    top: 1px;
    margin-left: -10px;
    border-top-width: 0;
    border-bottom-color: white; }
.popover.left > .arrow {
  top: 50%;
  right: -11px;
  margin-top: -11px;
  border-right-width: 0;
  border-left-color: #999999;
  border-left-color: rgba(0, 0, 0, 0.25); }
  .popover.left > .arrow:after {
    content: " ";
    right: 1px;
    border-right-width: 0;
    border-left-color: white;
    bottom: -10px; }

.carousel {
  position: relative; }

.carousel-inner {
  position: relative;
  overflow: hidden;
  width: 100%; }
  .carousel-inner > .item {
    display: none;
    position: relative;
    -webkit-transition: 0.6s ease-in-out left;
    -o-transition: 0.6s ease-in-out left;
    transition: 0.6s ease-in-out left; }
    .carousel-inner > .item > img,
    .carousel-inner > .item > a > img {
      display: block;
      max-width: 100%;
      height: auto;
      line-height: 1; }
  .carousel-inner > .active,
  .carousel-inner > .next,
  .carousel-inner > .prev {
    display: block; }
  .carousel-inner > .active {
    left: 0; }
  .carousel-inner > .next,
  .carousel-inner > .prev {
    position: absolute;
    top: 0;
    width: 100%; }
  .carousel-inner > .next {
    left: 100%; }
  .carousel-inner > .prev {
    left: -100%; }
  .carousel-inner > .next.left,
  .carousel-inner > .prev.right {
    left: 0; }
  .carousel-inner > .active.left {
    left: -100%; }
  .carousel-inner > .active.right {
    left: 100%; }

.carousel-control {
  position: absolute;
  top: 0;
  left: 0;
  bottom: 0;
  width: 15%;
  opacity: 0.5;
  filter: alpha(opacity=50);
  font-size: 20px;
  color: white;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6); }
  .carousel-control.left {
    background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.5) 0%), color-stop(rgba(0, 0, 0, 0.0001) 100%));
    background-image: -o-linear-gradient(left, rgba(0, 0, 0, 0.5) 0%, rgba(0, 0, 0, 0.0001) 100%);
    background-image: linear-gradient(to right, rgba(0, 0, 0, 0.5) 0%, rgba(0, 0, 0, 0.0001) 100%);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#80000000', endColorstr='#00000000', GradientType=1); }
  .carousel-control.right {
    left: auto;
    right: 0;
    background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.0001) 0%), color-stop(rgba(0, 0, 0, 0.5) 100%));
    background-image: -o-linear-gradient(left, rgba(0, 0, 0, 0.0001) 0%, rgba(0, 0, 0, 0.5) 100%);
    background-image: linear-gradient(to right, rgba(0, 0, 0, 0.0001) 0%, rgba(0, 0, 0, 0.5) 100%);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#80000000', GradientType=1); }
  .carousel-control:hover, .carousel-control:focus {
    outline: 0;
    color: white;
    text-decoration: none;
    opacity: 0.9;
    filter: alpha(opacity=90); }
  .carousel-control .icon-prev,
  .carousel-control .icon-next,
  .carousel-control .glyphicon-chevron-left,
  .carousel-control .glyphicon-chevron-right {
    position: absolute;
    top: 50%;
    z-index: 5;
    display: inline-block; }
  .carousel-control .icon-prev,
  .carousel-control .glyphicon-chevron-left {
    left: 50%;
    margin-left: -10px; }
  .carousel-control .icon-next,
  .carousel-control .glyphicon-chevron-right {
    right: 50%;
    margin-right: -10px; }
  .carousel-control .icon-prev,
  .carousel-control .icon-next {
    width: 20px;
    height: 20px;
    margin-top: -10px;
    font-family: serif; }
  .carousel-control .icon-prev:before {
    content: '\2039'; }
  .carousel-control .icon-next:before {
    content: '\203a'; }

.carousel-indicators {
  position: absolute;
  bottom: 10px;
  left: 50%;
  z-index: 15;
  width: 60%;
  margin-left: -30%;
  padding-left: 0;
  list-style: none;
  text-align: center; }
  .carousel-indicators li {
    display: inline-block;
    width: 10px;
    height: 10px;
    margin: 1px;
    text-indent: -999px;
    border: 1px solid white;
    border-radius: 10px;
    cursor: pointer;
    background-color: #000 \9;
    background-color: transparent; }
  .carousel-indicators .active {
    margin: 0;
    width: 12px;
    height: 12px;
    background-color: white; }

.carousel-caption {
  position: absolute;
  left: 15%;
  right: 15%;
  bottom: 20px;
  z-index: 10;
  padding-top: 20px;
  padding-bottom: 20px;
  color: white;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6); }
  .carousel-caption .btn {
    text-shadow: none; }

@media screen and (min-width: 768px) {
  .carousel-control .glyphicon-chevron-left,
  .carousel-control .glyphicon-chevron-right,
  .carousel-control .icon-prev,
  .carousel-control .icon-next {
    width: 30px;
    height: 30px;
    margin-top: -15px;
    font-size: 30px; }
  .carousel-control .glyphicon-chevron-left,
  .carousel-control .icon-prev {
    margin-left: -15px; }
  .carousel-control .glyphicon-chevron-right,
  .carousel-control .icon-next {
    margin-right: -15px; }

  .carousel-caption {
    left: 20%;
    right: 20%;
    padding-bottom: 30px; }

  .carousel-indicators {
    bottom: 20px; } }
.clearfix:before, .clearfix:after {
  content: " ";
  display: table; }
.clearfix:after {
  clear: both; }

.center-block {
  display: block;
  margin-left: auto;
  margin-right: auto; }

.pull-right {
  float: right !important; }

.pull-left {
  float: left !important; }

.hide {
  display: none !important; }

.show {
  display: block !important; }

.invisible {
  visibility: hidden; }

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0; }

.hidden {
  display: none !important;
  visibility: hidden !important; }

.affix {
  position: fixed; }

@-ms-viewport {
  width: device-width; }
.visible-xs, .visible-sm, .visible-md, .visible-lg {
  display: none !important; }

.visible-xs-block,
.visible-xs-inline,
.visible-xs-inline-block,
.visible-sm-block,
.visible-sm-inline,
.visible-sm-inline-block,
.visible-md-block,
.visible-md-inline,
.visible-md-inline-block,
.visible-lg-block,
.visible-lg-inline,
.visible-lg-inline-block {
  display: none !important; }

@media (max-width: 767px) {
  .visible-xs {
    display: block !important; }

  table.visible-xs {
    display: table; }

  tr.visible-xs {
    display: table-row !important; }

  th.visible-xs,
  td.visible-xs {
    display: table-cell !important; } }
@media (max-width: 767px) {
  .visible-xs-block {
    display: block !important; } }

@media (max-width: 767px) {
  .visible-xs-inline {
    display: inline !important; } }

@media (max-width: 767px) {
  .visible-xs-inline-block {
    display: inline-block !important; } }

@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important; }

  table.visible-sm {
    display: table; }

  tr.visible-sm {
    display: table-row !important; }

  th.visible-sm,
  td.visible-sm {
    display: table-cell !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm-block {
    display: block !important; } }

@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm-inline {
    display: inline !important; } }

@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm-inline-block {
    display: inline-block !important; } }

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important; }

  table.visible-md {
    display: table; }

  tr.visible-md {
    display: table-row !important; }

  th.visible-md,
  td.visible-md {
    display: table-cell !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md-block {
    display: block !important; } }

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md-inline {
    display: inline !important; } }

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md-inline-block {
    display: inline-block !important; } }

@media (min-width: 1200px) {
  .visible-lg {
    display: block !important; }

  table.visible-lg {
    display: table; }

  tr.visible-lg {
    display: table-row !important; }

  th.visible-lg,
  td.visible-lg {
    display: table-cell !important; } }
@media (min-width: 1200px) {
  .visible-lg-block {
    display: block !important; } }

@media (min-width: 1200px) {
  .visible-lg-inline {
    display: inline !important; } }

@media (min-width: 1200px) {
  .visible-lg-inline-block {
    display: inline-block !important; } }

@media (max-width: 767px) {
  .hidden-xs {
    display: none !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm {
    display: none !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md {
    display: none !important; } }
@media (min-width: 1200px) {
  .hidden-lg {
    display: none !important; } }
.visible-print {
  display: none !important; }

@media print {
  .visible-print {
    display: block !important; }

  table.visible-print {
    display: table; }

  tr.visible-print {
    display: table-row !important; }

  th.visible-print,
  td.visible-print {
    display: table-cell !important; } }
.visible-print-block {
  display: none !important; }
  @media print {
    .visible-print-block {
      display: block !important; } }

.visible-print-inline {
  display: none !important; }
  @media print {
    .visible-print-inline {
      display: inline !important; } }

.visible-print-inline-block {
  display: none !important; }
  @media print {
    .visible-print-inline-block {
      display: inline-block !important; } }

@media print {
  .hidden-print {
    display: none !important; } }
#admin-menu,
#admin-menu .dropdown {
  z-index: 9999; }

#user-login input {
  width: 300px; }

.row {
  margin: 0; }

ul {
  list-style-type: none !important; }

@font-face {
  font-family: 'HeroRegular';
  src: url("/sites/all/themes/law_library_bootstrap/fonts/hero-webfont.eot");
  src: url("/sites/all/themes/law_library_bootstrap/fonts/hero-webfont.eot?#iefix") format("embedded-opentype"), url("/sites/all/themes/law_library_bootstrap/fonts/hero-webfont.woff") format("woff"), url("/sites/all/themes/law_library_bootstrap/fonts/hero-webfont.ttf") format("truetype");
  font-weight: normal;
  font-style: normal; }
@font-face {
  font-family: 'HeroLight';
  src: url("/sites/all/themes/law_library_bootstrap/fonts/hero_light-webfont.eot");
  src: url("/sites/all/themes/law_library_bootstrap/fonts/hero_light-webfont.eot?#iefix") format("embedded-opentype"), url("/sites/all/themes/law_library_bootstrap/fonts/hero_light-webfont.woff") format("woff"), url("/sites/all/themes/law_library_bootstrap/fonts/hero_light-webfont.ttf") format("truetype");
  font-weight: normal;
  font-style: normal; }
@font-face {
  font-family: "Glyphicons Halflings";
  src: url("../fonts/bootstrap/glyphicons-halflings-regular.eot?#iefix") format("embedded-opentype"), url("../fonts/bootstrap/glyphicons-halflings-regular.woff") format("woff"), url("../fonts/bootstrap/glyphicons-halflings-regular.ttf") format("truetype"), url("../fonts/bootstrap/glyphicons-halflings-regular.svg#glyphicons_halflingsregular") format("svg"); }
body {
  font-family: "Montserrat", sans-serif;
  background-color: #fff;
  overflow-x: hidden; }

body.front {
  background-color: #252525; }

a {
  color: #129792; }

a:hover {
  text-decoration: none; }

.caret-icon {
  display: inline-block;
  /* Safari */
  -webkit-transform: rotate(-90deg);
  /* Firefox */
  -moz-transform: rotate(-90deg);
  /* IE */
  -ms-transform: rotate(-90deg);
  /* Opera */
  -o-transform: rotate(-90deg);
  /* Internet Explorer */
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=3);
  /* Modern */
  transform: rotate(90deg);
  margin-left: 3px; }

.cul-branding {
  height: 45px;
  width: 100%;
  margin: 0 auto;
  background-color: #b11d22;
  position: absolute;
  z-index: 9996;
  left: 0;
  right: 0;
  top: 0;
  pointer-events: auto; }
  .cul-branding .cu-logo {
    background: url("../images/cul-branding/cu-logo-small.png") no-repeat top right;
    margin-left: 10px;
    width: 153px;
    height: 45px;
    display: inline-block; }

.user-tools {
  float: right;
  z-index: 9999;
  margin-right: 38px;
  width: 100px; }
  .user-tools ul {
    padding-left: 0; }
    .user-tools ul li {
      display: inline-block;
      float: left;
      padding-right: 5px;
      padding-top: 7px; }
      .user-tools ul li a {
        font-size: 25px;
        color: #fff; }
      .user-tools ul li a.reservations-icon span {
        padding-left: 2px; }

.main-nav {
  top: 65px;
  width: 100%;
  margin: 0 auto;
  position: absolute;
  z-index: 9997;
  overflow: hidden;
  left: 0;
  width: 298px;
  display: inline-block; }
  .main-nav h1 {
    margin-top: 0;
    padding-left: 20px;
    width: 298px;
    float: left; }
  .main-nav ul {
    list-style-type: none;
    display: inline;
    float: right;
    margin-top: 35px;
    color: #fff;
    margin-right: 20px; }
    .main-nav ul li {
      float: left;
      margin-right: 8px; }
      .main-nav ul li a {
        font-size: 16px;
        font-family: "HeroRegular";
        color: #fff;
        padding-right: 4px; }
        .main-nav ul li a.active {
          color: #95d8fe;
          padding-bottom: 3px;
          border-bottom: 2px solid #95d8fe; }
        .main-nav ul li a:hover {
          color: #95d8fe;
          padding-bottom: 3px;
          border-bottom: 2px solid #95d8fe; }

.hero {
  position: relative;
  background-color: #313639;
  /* Carousel base class */
    /*.carousel.carousel-fade .item {
        -webkit-transition: opacity 0.1s ease-in-out;
        -moz-transition: opacity 0.1s ease-in-out;
        -ms-transition: opacity 0.1s ease-in-out;
        -o-transition: opacity 0.1s ease-in-out;
        transition: opacity 0.1s ease-in-out;
        opacity:0;
    }

    .carousel.carousel-fade .active.item {
        opacity:1;
    }*/ }
  .hero .carousel .container {
    position: relative;
    z-index: 9;
    width: 100%; }
  .hero .carousel-control {
    height: 80px;
    margin-top: 0;
    font-size: 120px;
    text-shadow: 0 1px 1px rgba(0, 0, 0, 0.4);
    background-color: transparent;
    border: 0;
    z-index: 10; }
  .hero .carousel .item {
    height: 589px; }
  .hero .carousel img {
    position: absolute;
    top: 0;
    left: 0;
    min-width: 100%;
    height: 589px; }
  .hero .carousel-caption {
    background-color: transparent;
    position: static;
    max-width: 550px;
    padding: 0 20px;
    padding-left: 0;
    margin-top: 390px;
    text-align: left;
    margin-left: 0;
    padding-top: 40px;
    margin-left: 10px; }
    .hero .carousel-caption h1 {
      font-size: 20px;
      color: #fff;
      padding-bottom: 10px;
      font-weight: normal; }
    .hero .carousel-caption p {
      font-size: 16px;
      color: #fff;
      font-weight: normal; }
  .hero .carousel-caption h1,
  .hero .carousel-caption .lead {
    margin: 0;
    line-height: 1.25;
    color: #fff;
    text-shadow: 0 1px 1px rgba(0, 0, 0, 0.4); }
  .hero .carousel-caption .btn {
    margin-top: 10px; }
  .hero .carousel-indicators {
    position: absolute;
    left: 0;
    margin-left: 15px;
    padding-left: 10px;
    width: 70%;
    bottom: 55px; }
    .hero .carousel-indicators li {
      float: left;
      display: block;
      width: 45px;
      height: 5px;
      background-color: #fff;
      border-radius: 0;
      border: none;
      margin-right: 3px; }
    .hero .carousel-indicators li.active {
      background-color: #1ebae1 !important;
      margin-top: 1px; }
  .hero .carousel-control.left,
  .hero .carousel-control.right {
    display: none; }

.search-home {
  position: absolute;
  top: 170px;
  left: 0;
  width: 100%;
  height: 190px;
  background-color: rgba(255, 255, 255, 0.26);
  padding-left: 15px;
  z-index: 9996; }
  .search-home label {
    font-size: 27px;
    color: #fff;
    padding-top: 15px;
    font-weight: 400;
    line-height: 1.1em;
    padding-bottom: 5px; }
    .search-home label .search-filter-selected {
      opacity: .5; }
  .search-home .filtered-search {
    font-size: 16px;
    color: #2c3235;
    position: relative; }
    .search-home .filtered-search .search-homepage {
      float: left;
      width: 65%;
      height: 51px;
      background-color: #fff;
      padding-left: 10px;
      vertical-align: text-top;
      -moz-border-radius: 3px 0px 0px 3px;
      -webkit-border-radius: 3px 0px 0px 3px;
      border-radius: 3px 0px 0px 3px;
      border: 1px solid #d6d6d6; }
    .search-home .filtered-search .filter-search {
      position: relative;
      float: left;
      height: 51px;
      background-color: #fff;
      width: 50px;
      -moz-border-radius: 0px 3px 3px 0px;
      -webkit-border-radius: 0px 3px 3px 0px;
      border-radius: 0px 3px 3px 0px;
      border: 1px solid #d6d6d6;
      cursor: pointer; }
      .search-home .filtered-search .filter-search .active {
        display: none; }
      .search-home .filtered-search .filter-search .glyphicon-chevron-down {
        color: #1ebae1;
        font-size: 25px;
        line-height: 51px;
        padding-left: 10px; }
      .search-home .filtered-search .filter-search .filter-default {
        -ms-transform: rotate(0deg);
        /* IE 9 */
        -webkit-transform: rotate(0deg);
        /* Chrome, Safari, Opera */
        transform: rotate(0deg); }
      .search-home .filtered-search .filter-search .filter-active {
        -ms-transform: rotate(180deg);
        /* IE 9 */
        -webkit-transform: rotate(180deg);
        /* Chrome, Safari, Opera */
        transform: rotate(180deg);
        padding-right: 12px; }
    .search-home .filtered-search #filter-search-nav {
      position: absolute;
      display: none;
      background-color: #fff;
      border: 1px solid #fff;
      right: -1px;
      top: 50px;
      width: 190px;
      list-style-type: none !important;
      padding-left: 0; }
      .search-home .filtered-search #filter-search-nav li {
        padding-left: 13px;
        height: 51px;
        line-height: 51px;
        border-bottom: 1px solid #d6d6d6; }
    .search-home .filtered-search .submit-search {
      float: left;
      vertical-align: text-top;
      width: 51px;
      height: 51px;
      text-align: center;
      font-size: 40px;
      padding-top: 0;
      background-color: transparent;
      border: none;
      color: #fff;
      padding-left: 15px; }
  .search-home .external-search {
    clear: both;
    list-style-type: none;
    padding-left: 0;
    padding-top: 10px;
    width: auto; }
    .search-home .external-search li {
      color: #fff;
      padding-right: 5px;
      float: left; }
      .search-home .external-search li a {
        color: #fff; }

.search-slider {
  display: none;
  height: 210px;
  width: 100%;
  background-color: #b11d22;
  z-index: 9999;
  position: absolute;
  top: 0;
  left: 0; }

.close-search {
  display: none;
  font-size: 28px;
  color: #fff;
  position: absolute;
  top: 10px;
  right: 20px;
  z-index: 99999; }
  .close-search:hover, .close-search:focus {
    color: #fff; }

.search-interior {
  position: absolute;
  top: 20px;
  left: 0;
  width: 100%;
  height: 190px;
  padding-left: 15px;
  z-index: 89999; }
  .search-interior label {
    font-size: 27px;
    color: #fff;
    padding-top: 18px;
    font-weight: 400;
    line-height: 1.1em; }
    .search-interior label .search-filter-selected {
      opacity: .5; }
  .search-interior .filtered-search {
    font-size: 16px;
    color: #2c3235;
    position: relative; }
    .search-interior .filtered-search .search-homepage {
      float: left;
      width: 65%;
      height: 51px;
      background-color: #fff;
      padding-left: 10px;
      vertical-align: text-top;
      -moz-border-radius: 3px 0px 0px 3px;
      -webkit-border-radius: 3px 0px 0px 3px;
      border-radius: 3px 0px 0px 3px;
      border: 1px solid #d6d6d6; }
    .search-interior .filtered-search .filter-search {
      position: relative;
      float: left;
      height: 51px;
      background-color: #fff;
      width: 50px;
      -moz-border-radius: 0px 3px 3px 0px;
      -webkit-border-radius: 0px 3px 3px 0px;
      border-radius: 0px 3px 3px 0px;
      border: 1px solid #d6d6d6;
      cursor: pointer; }
      .search-interior .filtered-search .filter-search .active {
        display: none; }
      .search-interior .filtered-search .filter-search .glyphicon-chevron-down {
        color: #1ebae1;
        font-size: 25px;
        line-height: 51px;
        padding-left: 10px; }
      .search-interior .filtered-search .filter-search .filter-default {
        -ms-transform: rotate(0deg);
        /* IE 9 */
        -webkit-transform: rotate(0deg);
        /* Chrome, Safari, Opera */
        transform: rotate(0deg); }
      .search-interior .filtered-search .filter-search .filter-active {
        -ms-transform: rotate(180deg);
        /* IE 9 */
        -webkit-transform: rotate(180deg);
        /* Chrome, Safari, Opera */
        transform: rotate(180deg);
        padding-right: 12px; }
    .search-interior .filtered-search #filter-search-nav {
      position: absolute;
      display: none;
      background-color: #fff;
      border: 1px solid #fff;
      right: -1px;
      top: 50px;
      width: 190px;
      list-style-type: none !important;
      padding-left: 0; }
      .search-interior .filtered-search #filter-search-nav li {
        padding-left: 13px;
        height: 51px;
        line-height: 51px;
        border-bottom: 1px solid #d6d6d6; }
    .search-interior .filtered-search .submit-search {
      float: left;
      vertical-align: text-top;
      width: 51px;
      height: 51px;
      text-align: center;
      font-size: 40px;
      padding-top: 0;
      background-color: transparent;
      border: none;
      color: #fff;
      padding-left: 15px; }
  .search-interior .external-search {
    clear: both;
    list-style-type: none;
    padding-left: 0;
    padding-top: 10px;
    width: auto; }
    .search-interior .external-search li {
      color: #fff;
      padding-right: 5px;
      float: left; }
      .search-interior .external-search li a {
        color: #fff; }

.reservation-hours {
  position: absolute;
  top: 492px;
  right: -7px;
  background: url("../images/home-hero-info.png") no-repeat top right;
  height: 111px;
  width: 566px; }
  .reservation-hours .reservations-icon {
    position: absolute;
    color: #fff;
    font-size: 12px;
    bottom: 40px;
    right: 30px; }
  .reservation-hours .hours-icon {
    color: #fff;
    position: absolute;
    right: 30px;
    bottom: 13px; }
    .reservation-hours .hours-icon .status {
      padding: 5px 7px;
      background-color: #5a842e;
      color: #fff;
      -webkit-border-radius: 3px;
      -moz-border-radius: 3px;
      border-radius: 3px; }

#superfish-4 {
  margin-bottom: 0; }

.media {
  background-color: #252525;
  padding-top: 60px;
  padding-bottom: 40px;
  margin: 0 auto;
  position: relative;
  margin-top: 14px; }
  .media .owl-carousel {
    width: 98%;
    margin: 0 auto; }
  .media .owl-stage .owl-item {
    position: relative;
    margin-right: 30px; }
    .media .owl-stage .owl-item .mask-media {
      position: absolute;
      top: 0;
      left: 0; }
    .media .owl-stage .owl-item figcaption {
      font-size: 18px;
      color: #aabec7;
      text-align: left;
      padding-top: 17px; }
      .media .owl-stage .owl-item figcaption a {
        font-size: 17px;
        color: #aabec7;
        padding-top: 16px; }
  .media .customPrevBtn {
    position: absolute;
    left: 5px;
    top: 22%;
    font-family: "HeroLight";
    color: #1ebae1;
    font-size: 90px;
    display: none; }
  .media .customNextBtn {
    position: absolute;
    right: 5px;
    top: 22%;
    font-family: "HeroLight";
    color: #1ebae1;
    font-size: 90px;
    display: none; }

/*
##############################################
###### FOOTER
##############################################
*/
body.front footer.row {
  height: 400px;
  background-color: #fff;
  margin-top: 5px;
  padding-top: 30px;
  border-top: 1px solid #f0f0f0; }

footer.row {
  height: 77px;
  background-color: #fff;
  margin-top: 5px;
  padding-top: 30px;
  border-top: 1px solid #f0f0f0 !important; }
  footer.row .wrapper {
    width: 93%;
    margin: 0 auto;
    padding-top: 0;
    text-align: center;
    padding-bottom: 20px;
    overflow: hidden; }
  footer.row .address-copyright p {
    font-size: 12px;
    color: #242424; }
  footer.row .address-copyright small {
    display: inline-block; }
  footer.row .navigation {
    padding-left: 15px;
    padding-top: 10px;
    text-align: center; }
    footer.row .navigation li {
      padding-right: 5px;
      display: inline-block; }
      footer.row .navigation li a {
        display: inline-block;
        font-weight: 12px;
        color: #242424; }
        footer.row .navigation li a.active {
          color: #7d7d7d; }
        footer.row .navigation li a:hover {
          color: #7d7d7d; }
  footer.row .social-media {
    text-align: center; }
    footer.row .social-media li {
      padding-right: 8px;
      display: inline-block; }

.breadcrumb {
  background-color: #fff;
  padding-left: 0;
  font-size: 16px;
  padding-top: 0;
  margin-bottom: 0;
  padding-top: 15px; }
  .breadcrumb .separator {
    font-size: 16px; }

p {
  font-size: 18px;
  font-family: "Montserrat", sans-serif;
  color: #64686a; }

h2 {
  font-size: 40px;
  font-family: "Montserrat", sans-serif;
  color: #b11d22;
  font-weight: bold; }

header.page {
  border-bottom: 1px solid #ebebeb;
  margin-bottom: 27px; }
  header.page .title-content {
    display: inline-block;
    text-transform: uppercase;
    border-bottom: 5px solid #ebebeb;
    margin-bottom: 0;
    margin-top: 10px; }

h3 {
  font-size: 18px;
  font-family: "Montserrat", sans-serif;
  color: #b11d22;
  font-weight: bold;
  margin-bottom: 5px; }

.header-interior {
  background: white url("../images/header-interior.jpg") no-repeat top center;
  background-size: cover;
  height: 160px;
  position: relative; }
  .header-interior .mask-interior {
    background: transparent url("../images/mask-interior.png") no-repeat bottom right;
    height: 18px;
    width: 100%;
    position: absolute;
    bottom: 0;
    right: 0; }

.page-content .main-content {
  border-right: 1px solid #ebebeb; }
  .page-content .main-content .content {
    margin-top: 0; }
    .page-content .main-content .content h3 {
      font-size: 32px;
      font-family: "Montserrat", sans-serif;
      color: #333333;
      font-weight: normal;
      margin-bottom: 20px; }
    .page-content .main-content .content h4 {
      font-size: 28px;
      font-family: "Montserrat", sans-serif;
      color: #b11d22;
      font-weight: bold;
      margin-bottom: 20px; }
    .page-content .main-content .content h5 {
      font-size: 24px;
      font-family: "Montserrat", sans-serif;
      color: #b11d22;
      font-weight: bold;
      margin-bottom: 20px; }
    .page-content .main-content .content ul {
      color: #64686a;
      font-family: "Montserrat", sans-serif;
      font-size: 18px;
      list-style-type: disc !important;
      padding-bottom: 20px; }
    .page-content .main-content .content ol {
      color: #64686a !important;
      font-family: "Montserrat", sans-serif;
      font-size: 18px;
      list-style-type: disc !important;
      padding-bottom: 20px; }
    .page-content .main-content .content table {
      color: #64686a !important;
      font-family: "Montserrat", sans-serif;
      font-size: 18px; }
    .page-content .main-content .content img {
      border: 5px solid #ebebeb !important;
      display: block !important;
      max-width: 100% !important;
      height: auto !important;
      margin-bottom: 30px; }
    .page-content .main-content .content .right {
      float: right;
      margin: 0 !important;
      margin-left: 20px !important;
      margin-bottom: 30px !important; }
.page-content .sidebar-nav {
  margin-top: 40px; }
  .page-content .sidebar-nav h4 {
    font-size: 22px;
    color: #b11d22; }
    .page-content .sidebar-nav h4.linked {
      border-bottom: 1px solid #c6c7c8;
      padding-bottom: 20px;
      padding-top: 20px;
      margin: 0; }
    .page-content .sidebar-nav h4 a {
      font-size: 22px;
      color: #b11d22; }
      .page-content .sidebar-nav h4 a .separator {
        font-size: 22px;
        padding-left: 5px; }
  .page-content .sidebar-nav ul {
    padding-top: 28px;
    padding-bottom: 28px;
    margin-bottom: 0;
    border-top: 2px dotted #ebebeb; }
    .page-content .sidebar-nav ul li {
      font-size: 16px;
      line-height: 1.2em;
      padding-bottom: 5px; }
      .page-content .sidebar-nav ul li a {
        padding: 0;
        padding-bottom: 5px; }
      .page-content .sidebar-nav ul li a:hover,
      .page-content .sidebar-nav ul li a:focus {
        background-color: transparent; }
      .page-content .sidebar-nav ul li a::after {
        font-family: "HeroRegular";
        font-size: 24px;
        padding-left: 5px;
        content: ">";
        vertical-align: middle; }
.page-content .main-content-one-column {
  padding: 0;
  padding-left: 15px; }
  .page-content .main-content-one-column .content {
    margin-top: 0;
    padding-right: 30px; }
    .page-content .main-content-one-column .content h3 {
      font-size: 32px;
      font-family: "Montserrat", sans-serif;
      color: #333333;
      font-weight: normal;
      margin-bottom: 20px; }
    .page-content .main-content-one-column .content h4 {
      font-size: 28px;
      font-family: "Montserrat", sans-serif;
      color: #b11d22;
      font-weight: bold;
      margin-bottom: 20px; }
    .page-content .main-content-one-column .content h5 {
      font-size: 24px;
      font-family: "Montserrat", sans-serif;
      color: #b11d22;
      font-weight: bold;
      margin-bottom: 20px; }
    .page-content .main-content-one-column .content ul {
      color: #64686a;
      font-family: "Montserrat", sans-serif;
      font-size: 18px;
      list-style-type: disc !important;
      padding-bottom: 20px; }
    .page-content .main-content-one-column .content ol {
      color: #64686a !important;
      font-family: "Montserrat", sans-serif;
      font-size: 18px;
      list-style-type: disc !important;
      padding-bottom: 20px; }
    .page-content .main-content-one-column .content table {
      color: #64686a !important;
      font-family: "Montserrat", sans-serif;
      font-size: 18px; }
    .page-content .main-content-one-column .content img {
      border: 5px solid #ebebeb !important;
      display: block !important;
      max-width: 100% !important;
      height: auto !important;
      margin-bottom: 30px; }
    .page-content .main-content-one-column .content .right {
      float: right;
      margin: 0 !important;
      margin-left: 20px !important;
      margin-bottom: 30px; }

/*
.container-nav {
    clear: both;
    display: table;
    padding-bottom: 1em;
}

    .row {
      display: table-row;
    }

        .cell {
          display: table-cell;
          padding: 1em;
          vertical-align: top;
          border-right: 1px dotted #bdc7c4;


        }


        .cell:last-child {
          vertical-align: top;
          border-right: none;
        }


#nav {
    width: 100%; 
    font-family: 'abel', sans-serif;
    font-weight: 400;
    
    position: relative;
    margin: 0 auto;
    margin-top: 80px;
    
    position: absolute;
    top: 0;
    z-index: 9997;
}

#nav ul {
    margin: 0;
    padding-left: 10px;
    width: 90%;
}

    #nav > a {
        display: none;
    }

    #nav li {
        //REMOVE THIS TO CONTROL SUBMENUS
        position: relative;
        list-style-type: none;
    }
        #nav li a {
            color: #243038;
            display: block;
            text-decoration: none;
        }
        
        #nav li a:active
        {
            //background-color: #c00 !important;
        }

    #nav span:after
    {

    }

    // first level 

    #nav > ul
    {
        height: 2.1em; 
    }

    #nav  ul
    {
        float: right;
        width: auto;
    }
        #nav > ul > li
        {
            width: auto;
            height: 100%;
            float: left;
        }

        #nav > ul  li.first
        {
            padding-left: 0;
        }
            #nav > ul > li > a
            {
                height: 100%;
                font-size: 22px;
                line-height: 2.5em; 
                text-align: center;
                padding-left: 0;
                padding-right: 5px;
                color: #fff;

                span {

                    font-size: 12px;

                }
            }

            #nav > ul > li > a:after
            {
                content:  " /";
                font-weight: 100;
            }

             #nav > ul > li:last-child > a:after
            {
                content:  "";
                padding-right: 10px;
            }

            #nav > ul > li > a.active
            {
                color: #95d8fe;
            }

            #nav > ul > li > a.active-submenu
            {
                background-color: #0d6d98;
                line-height: 1.5em;
                height: 30px;
            }
            


                #nav > ul > li:not( :last-child ) > a
                {
                    
                }
                #nav > ul > li:hover > a,
                #nav > ul:not( :hover ) > li.active > a
                {
                    //background-color: #0085c0;
                    color: #95d8fe;
                }


        // second level 

        #nav li ul
        {
            background-color: rgba(255, 255, 255, 1);
            display: none;
            position: absolute;
            //top: 100%;
            top: 40px;
            left: 0;
            right: 0;
            margin: 0 auto;
            padding-left: 5px;
            overflow: hidden;
            
            width: 100%;
            border-bottom: 1px dotted #bdc7c4;
            padding-top: 5px;



                                
        }
            #nav li ul .sub-items {

                margin: 25px;
                margin-bottom: 0;
                float: left;
                margin: 0 auto;
            }

            #nav li ul .sub-items > a {

                margin-bottom: 8px;
                margin-top: 8px;
                font-size: 22px;
                padding-left: 0px;
                padding-right: 5px;
                font-weight: bold;

            }

            #nav li ul .sub-items > a:hover {

                color: #428bca;
            }

            #nav li ul .sub-items > a::before {

                //content: ">";
                //padding-right: 5px;
                //font-size: .8em;
            }

            #nav li ul .sub-items > a.sub-sub-items {

                padding-left: 10px;
                font-weight: 400;
                line-height: 1.2em;
            }

            #nav li ul .sub-items > a.sub-sub-items:hover {

                color: #428bca;
            }

            #nav li ul .sub-items > a.sub-sub-items::before {

                //content: "-";
                //margin-right: 10px;

            }



            #nav li:hover ul
            {
                display: block;
                left: 0;
                right: 0;
            }
                #nav li:not( :first-child ):hover ul
                {
                    //left: -1px;

                }
                
                /*#nav li ul a
                {
                    font-size: 1em; /* 20 */
/*border-top: 1px solid #3f3c3a;
padding: 0.75em; /* 15 (20) */
    /*padding-left: 0;
}
    #nav li ul li a:hover,
    #nav li ul:not( :hover ) li.active a
    {
        background-color: #cc470d;
    }*/
/*
@media only screen and ( max-width: 640px ) {
    html
    {
        font-size: 75%;
    }


    .container-nav {
        clear: both;
        display: block;

    }

    .row {
      display: block;
      padding-bottom: 20px;
    }

    .cell {
      display: block;
      width: 100%;
      padding: 0;

    }

    .cell li {
        display: block;
        //border-bottom: 1px dotted #bdc7c4;
        float: left;
        width: 100%;
        
    }




    #nav
    {
        position: absolute;
        top: 0;
        left: 0;
        margin: 0;

    }   

        #nav > a
        {
            
            width: 3.125em; 
            height: 45px; 
            text-align: left;
            text-indent: -9999px;
            background-color: #3f3c3a;
            position: absolute;
            top: 0;
            right: 0;
        }

            #nav > a:before,
            #nav > a:after
            {
                position: absolute;
                border: 2px solid #fff;
                top: 35%;
                left: 25%;
                right: 25%;
                content: '';
            }
            #nav > a:after
            {
                top: 60%;
            }

        #nav:not( :target ) > a:first-of-type,
        #nav:target > a:last-of-type
        {
            display: block;
        }


    // first level 

    #nav > ul
    {
        height: auto;
        display: none;
        position: absolute;
        left: 0;
        right: 0;
        background-color: #fff;
        margin-top: 44px;
    }
        #nav:target > ul
        {
            display: block;
        }
        #nav > ul > li
        {
            width: 100%;
            float: none;
        }
            #nav > ul > li > a
            {
                height: auto;
                text-align: left;
                padding: 0 0.833em; 
                color: #000;

            }
                #nav > ul > li:not( :last-child ) > a
                {
                    border-right: none;
                    //border-bottom: 1px solid #3f3c3a;
                }
                
        // second level 

        #nav li ul
        {
            position: static;
            padding: 1.25em; 
            padding-bottom: 0;
            padding-top: 0;
            //border: 1px solid blue;
        }

        #nav li ul .sub-items a {

            padding-bottom: 0;
            padding-top: 0;
            margin: 0;
        }

        #nav li ul .sub-items > a.sub-sub-items {

                padding-left: 20px;
                display: none;
                border-bottom: none;

            }
}


// ##########################################
// ##########################################
// ##########################################












/* drupal overrides */
.contextual-links-region {
  position: inherit; }

.people {
  color: #64686a; }
  .people .top {
    display: block !important; }
  .people .people-photo {
    padding-left: 0;
    padding-right: 20px; }
    .people .people-photo img {
      border: 5px solid #ebebeb;
      width: 60%;
      height: 60%; }
  .people .people-data {
    font-size: 18px;
    padding-left: 10px;
    padding-right: 0;
    padding-top: 20px; }
    .people .people-data .field-name-field-title .field-item {
      font-size: 22px;
      margin-bottom: 20px; }
    .people .people-data .field {
      clear: both; }
      .people .people-data .field .field-label {
        float: left; }
      .people .people-data .field .field-item {
        float: left; }
  .people .people-body {
    padding-top: 30px;
    font-size: 18px; }

/* Extra small devices (phones, up to 480px) */
/* No media query since this is the default in Bootstrap */
/*
 __                 _ _   _____      _     _      _       
/ _\_ __ ___   __ _| | | /__   \__ _| |__ | | ___| |_ ___ 
\ \| '_ ` _ \ / _` | | |   / /\/ _` | '_ \| |/ _ \ __/ __|
_\ \ | | | | | (_| | | |  / / | (_| | |_) | |  __/ |_\__ \
\__/_| |_| |_|\__,_|_|_|  \/   \__,_|_.__/|_|\___|\__|___/

*/
@media (min-width: 323px) {
  .search-home label {
    padding-top: 27px; } }
@media (min-width: 480px) {
  .cul-branding .cu-logo {
    background: url("../images/cul-branding/cu-logo-medium.png") no-repeat top right;
    margin-left: 10px;
    width: 232px;
    height: 45px;
    display: inline-block; }

  .people .people-photo img {
    width: 60%;
    height: 60%; }

  footer.row {
    border-top: 1px solid #f0f0f0; }
    footer.row .wrapper {
      padding-top: 0; } }
@media (min-width: 560px) {
  .cul-branding .cu-logo {
    background: url("../images/cul-branding/cu-logo.png") no-repeat top right;
    margin-left: 10px;
    width: 343px;
    height: 45px;
    display: inline-block; } }
@media (min-width: 640px) {
  .cul-branding {
    width: 80%; }

  .user-tools {
    margin-right: 0; }

  body.front footer.row {
    border-top: 1px solid #f0f0f0; }
    body.front footer.row .wrapper {
      padding-top: 30px; }

  .people .people-photo img {
    width: 40%;
    height: 40%; }

  .search-home {
    top: 220px; }
    .search-home .filtered-search .search-homepage {
      width: 353px; }
    .search-home .filtered-search .filter-search {
      width: 190px;
      text-align: right; }
      .search-home .filtered-search .filter-search .active {
        display: inline;
        padding-left: 10px;
        line-height: 51px;
        vertical-align: top;
        padding-right: 0; }
      .search-home .filtered-search .filter-search .glyphicon-chevron-down {
        padding-right: 10px; }
    .search-home .filtered-search #filter-search-nav {
      display: none;
      width: 190px;
      text-align: left; }

  .search-interior {
    top: 20px;
    left: 38px; }
    .search-interior .filtered-search .search-homepage {
      width: 353px; }
    .search-interior .filtered-search .filter-search {
      width: 190px;
      text-align: right; }
      .search-interior .filtered-search .filter-search .active {
        display: inline;
        padding-left: 10px;
        line-height: 51px;
        vertical-align: top;
        padding-right: 0; }
      .search-interior .filtered-search .filter-search .glyphicon-chevron-down {
        padding-right: 10px; }
    .search-interior .filtered-search #filter-search-nav {
      display: none;
      width: 190px;
      text-align: left; }

  .page-content {
    display: block; }

    /*.page-content {


        .main-content {

            width: 100%;

            .content {
                
            }
        }

        .sidebar-nav {
    
        }
        
        /////////////

        .main-content-one-column {

            width: 100%;

            .content {
                
                img {

                    
                }
            }

        }
    }*/
  footer.row {
    border-top: 1px solid #f0f0f0; }
    footer.row .wrapper {
      padding-top: 30px; } }
@media (min-width: 600px) {
  .media .owl-carousel {
    width: 90%; }
  .media .customPrevBtn {
    position: absolute;
    left: 5px;
    top: 22%;
    font-family: "HeroLight";
    color: #1ebae1;
    font-size: 50px;
    display: block;
    padding-right: 10px; }
  .media .customPrevBtn:hover,
  .media .customPrevBtn:hover {
    text-decoration: none; }
  .media .customNextBtn {
    position: absolute;
    right: 5px;
    top: 22%;
    font-family: "HeroLight";
    color: #1ebae1;
    font-size: 50px;
    display: block;
    padding-left: 10px; }
  .media .customNextBtn:hover,
  .media .customNextBtn:hover {
    text-decoration: none; } }
/*
 _____      _     _      _       
/__   \__ _| |__ | | ___| |_ ___ 
  / /\/ _` | '_ \| |/ _ \ __/ __|
 / / | (_| | |_) | |  __/ |_\__ \
 \/   \__,_|_.__/|_|\___|\__|___/
                                 
*/
/* Small devices (tablets, 768px and up) */
@media (min-width: 768px) {
  .people .people-photo img {
    width: 100%;
    height: 100%; } }
 /*  
    ___          _    _              
   /   \___  ___| | _| |_ ___  _ __  
  / /\ / _ \/ __| |/ / __/ _ \| '_ \ 
 / /_//  __/\__ \   <| || (_) | |_) |
/___,' \___||___/_|\_\__\___/| .__/ 
                              |_|    
 */
/* Medium devices (desktops, 992px and up) */
@media (min-width: 992px) {
  .page-content .main-content {
    width: 70%; }
  .page-content .main-content-one-column {
    width: 100%; }
  .page-content .sidebar-nav {
    width: 30%;
    padding-left: 40px;
    padding-right: 40px;
    background: white url("../images/interior-bg.jpg") no-repeat 0 100px;
    background-size: contain;
    min-height: 1085px;
    margin-top: 40px; }
    .page-content .sidebar-nav ul {
      border-top: none; }

  body.front footer.row .wrapper {
    padding-top: 0; }

  .media .customPrevBtn {
    font-size: 90px;
    margin-left: 20px; }
  .media .customNextBtn {
    font-size: 90px;
    margin-right: 20px; }

  .people .people-photo img {
    width: 100%;
    height: 100%; }

  footer.row {
    display: block;
    margin: 0 auto; }
    footer.row .wrapper {
      padding-top: 30; }
    footer.row .address-copyright {
      text-align: left; }
    footer.row .social-media {
      text-align: right;
      display: inline-block; } }
@media (min-width: 998px) {
  .search-home {
    top: 215px; } }
/*
   __                           ___          _    _              
  / /  __ _ _ __ __ _  ___     /   \___  ___| | _| |_ ___  _ __  
 / /  / _` | '__/ _` |/ _ \   / /\ / _ \/ __| |/ / __/ _ \| '_ \ 
/ /__| (_| | | | (_| |  __/  / /_//  __/\__ \   <| || (_) | |_) |
\____/\__,_|_|  \__, |\___| /___,' \___||___/_|\_\__\___/| .__/ 
                |___/                                     |_|    
*/
/* Large devices (large desktops, 1200px and up) */
@media (min-width: 1200px) {
  .hero .carousel-indicators {
    padding-left: 200px;
    bottom: 55px; }
    .hero .carousel-indicators li {
      width: 65px;
      height: 7px; }
  .hero .carousel-caption {
    margin-left: 200px; }
    .hero .carousel-caption h1 {
      font-size: 24px;
      padding-bottom: 3px; }
    .hero .carousel-caption p {
      font-size: 18px; }

  .search-home {
    left: 200px;
    width: 677px; }
    .search-home #search {
      padding-left: 20px; }
      .search-home #search label {
        padding-top: 35px; }

  .page-content {
    display: block;
    width: 100%; }
    .page-content .main-content {
      width: 75%; }
    .page-content .main-content-one-column {
      width: 100%; }
    .page-content .sidebar-nav {
      width: 25%; } }
@media (min-width: 1350px) {
  .main-nav {
    z-index: 9998; } }
@media (min-width: 1300px) {
  .page-content {
    margin: 0 auto;
    display: block;
    width: 1200px; }
    .page-content .main-content {
      width: 900px; }
      .page-content .main-content .content {
        margin-top: 0; }
    .page-content .main-content-one-column {
      width: 1200px; }
    .page-content .sidebar-nav {
      width: 300px;
      padding-right: 0;
      margin-top: 60px; }

  footer.row {
    width: 100%; } }
a.sandwich {
  width: 3.125em;
  /* 50 */
  height: 45px;
  /* 50 */
  text-align: left;
  background-color: #3f3c3a;
  position: absolute;
  float: right;
  display: block;
  top: 0;
  right: 0;
  z-index: 99999; }
  a.sandwich:before, a.sandwich:after {
    position: absolute;
    border: 2px solid #fff;
    top: 35%;
    left: 25%;
    right: 25%;
    content: ''; }
  a.sandwich:after {
    top: 60%; }

#nav {
  position: absolute;
  top: 45px;
  width: 100%;
  display: none;
  z-index: 9997;
  background-color: #fff;
  padding-top: 20px;
  padding-bottom: 20px;
  border-bottom: 1px solid #d2d7d9; }
  #nav ul.first-level {
    display: block;
    margin: 0;
    list-style: none;
    font-family: 'abel', sans-serif;
    position: relative;
    padding-left: 20px; }
    #nav ul.first-level li.active {
      color: #95d8fe; }
    #nav ul.first-level li:hover a {
      color: #95d8fe;
      text-decoration: none; }
    #nav ul.first-level li:hover .wrapper {
      display: block;
      height: auto; }
    #nav ul.first-level li {
      font-size: 21px !important;
      display: inline-block;
      width: 100%;
      float: left;
      padding-right: 10px;
      color: #33383b;
      padding-top: 5px; }
      #nav ul.first-level li a {
        color: #33383b; }
        #nav ul.first-level li a span {
          font-size: 12px; }
      #nav ul.first-level li .wrapper {
        padding: 0;
        position: relative;
        width: 100%;
        display: none;
        padding-bottom: 10px;
        padding-top: 10px; }
        #nav ul.first-level li .wrapper .row {
          padding: 0;
          width: 90%;
          margin: 0 auto;
          display: block; }
          #nav ul.first-level li .wrapper .row div {
            padding-left: 0; }
            #nav ul.first-level li .wrapper .row div .center {
              width: 100%;
              border-right: none; }
              #nav ul.first-level li .wrapper .row div .center .second-level {
                margin-bottom: 2px;
                font-size: 21px !important;
                font-family: 'abel', sans-serif; }
                #nav ul.first-level li .wrapper .row div .center .second-level a {
                  display: inline-block;
                  color: #333333;
                  line-height: 26px; }
                #nav ul.first-level li .wrapper .row div .center .second-level a:hover {
                  color: #95d8fe; }
                #nav ul.first-level li .wrapper .row div .center .second-level img {
                  padding-bottom: 20px; }
              #nav ul.first-level li .wrapper .row div .center .third-level {
                color: #333333;
                padding-left: 20px;
                display: none;
                font-size: 21px !important;
                font-family: 'abel', sans-serif; }
                #nav ul.first-level li .wrapper .row div .center .third-level li {
                  display: block; }
                #nav ul.first-level li .wrapper .row div .center .third-level li:hover {
                  background: #fff;
                  color: gray; }
          #nav ul.first-level li .wrapper .row div:last-child {
            border-right: none; }

@media (min-width: 640px) {
  .main-nav {
    z-index: 9998; }

  a.sandwich {
    display: none; }

  #nav {
    position: absolute;
    width: 100%;
    top: 135px;
    display: block !important;
    z-index: 9997;
    float: left;
    background-color: transparent;
    border-bottom: none;
    padding-top: 0;
    padding-bottom: 0; }
    #nav ul.first-level {
      text-align: left;
      display: block;
      margin: 0;
      list-style: none;
      font-family: 'abel', sans-serif;
      position: relative; }
      #nav ul.first-level li.active {
        color: #95d8fe; }
      #nav ul.first-level li:hover a {
        color: #95d8fe;
        text-decoration: none; }
      #nav ul.first-level li:hover .wrapper {
        display: block;
        height: auto; }
      #nav ul.first-level li {
        text-align: left;
        font-size: 21px !important;
        display: inline-block;
        width: auto;
        padding-right: 10px;
        color: #fff;
        float: none; }
        #nav ul.first-level li a {
          color: #fff; }
          #nav ul.first-level li a span {
            font-size: 12px; }
        #nav ul.first-level li .wrapper {
          padding: 0;
          position: absolute;
          top: 32px;
          left: 0;
          width: 100%;
          background-color: #fff;
          display: none;
          padding-bottom: 20px;
          padding-top: 40px;
          min-height: 400px;
          border-bottom: 1px solid #d2d7d9; }
          #nav ul.first-level li .wrapper .row {
            padding: 0;
            width: 90%;
            margin: 0 auto;
            display: block;
            background-color: #fff; }
            #nav ul.first-level li .wrapper .row div {
              border-bottom: 1px solid #ebebeb;
              padding-bottom: 10px;
              margin-bottom: 30px; }
              #nav ul.first-level li .wrapper .row div .center {
                width: 70%;
                margin: 0 auto;
                border-right: none;
                border-bottom: none; }
                #nav ul.first-level li .wrapper .row div .center .second-level {
                  font-weight: bold;
                  margin-bottom: 2px;
                  font-size: 21px !important;
                  font-family: 'abel', sans-serif; }
                  #nav ul.first-level li .wrapper .row div .center .second-level a {
                    display: inline-block;
                    color: #333333;
                    line-height: 26px; }
                  #nav ul.first-level li .wrapper .row div .center .second-level a:hover {
                    color: #95d8fe; }
                #nav ul.first-level li .wrapper .row div .center .third-level {
                  padding-left: 20px;
                  display: block;
                  font-size: 21px !important;
                  font-family: 'abel', sans-serif; }
                  #nav ul.first-level li .wrapper .row div .center .third-level li {
                    display: block; }
                    #nav ul.first-level li .wrapper .row div .center .third-level li a {
                      display: inline-block;
                      color: #333333;
                      line-height: 24px; }
                    #nav ul.first-level li .wrapper .row div .center .third-level li a:hover {
                      color: #95d8fe; }
                  #nav ul.first-level li .wrapper .row div .center .third-level li:hover {
                    background: #fff;
                    color: gray; }
            #nav ul.first-level li .wrapper .row div:last-child {
              border-right: none;
              border-bottom: none; } }
@media (min-width: 768px) {
  #nav ul.first-level li .wrapper .row div {
    border-bottom: none;
    border-right: 1px solid #ebebeb; } }
@media (min-width: 1386px) {
  #nav {
    position: absolute;
    top: 89px;
    width: 100%;
    display: block !important;
    z-index: 9997;
    float: none; }
    #nav ul.first-level {
      text-align: right; } }
@media only screen and (min-width: 480px) {
  .header-interior {
    height: 160px; } }
@media only screen and (min-width: 640px) {
  .header-interior {
    height: 240px; } }
@media only screen and (min-width: 1080px) {
  .header-interior {
    height: 200px; } }
@media only screen and (min-width: 1386px) {
  .header-interior {
    height: 160px; } }
