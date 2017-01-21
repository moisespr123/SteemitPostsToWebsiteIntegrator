<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Steemit Posts</title>
<style>
h3 {
    color: black;
     font-family: Arial,serif;
    float: left;
}

div.image-div img {
    float: left;
}

p {
    color: black;
     font-family: Arial,serif;
    float: left;
}

.image-div {
    width: 700px;
    height: 180px;
}

.sideText {
    margin-left: 180px;
    text-align: left;
}
.sideText p {
    text-align: left;
}
</style>
</head>
<body>
<?php
//enter your MySQL Server Address, credentials and database below. Also, enter your Steemit username, which is used to show a link for your website visitors to visit your steemit account
$mysqlserver = 'server';
$mysqlusername = 'username';
$mysqlpassword = 'password';
$mysqldatabase = 'database';
$steemitaccount = 'Your Steemit Account';

$mysql=mysqli_connect($mysqlserver, $mysqlusername, $mysqlpassword, $mysqldatabase);
$sql="SELECT * FROM posts";
$result=mysqli_query($mysql, $sql);
$o = '';
while(list($header, $content, $url, $imagesrc) = mysqli_fetch_row($result)) {
	$o .= '<div class="image-div">
			<img height="150" src='.$imagesrc.' width="150" />
			 <div class="sideText">
				<h3><a href='.$url.' style="color: rgb(0,0,0)">'.$header.'</a></h3>
				<p><a href='.$url.' style="color: rgb(0,0,0)">'.$content.'</a></p>
			 </div>
			</div>';
}
echo $o;
echo '<br><br><a href=https://steemit.com/@'.$steemitaccount.'>More Steemit Posts</a>';
?>
</body>