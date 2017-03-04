# SteemitPostsToWebsiteIntegrator

This software will fetch your account posts summaries and send them to the database specified. You can also show your resteemed posts or hide them. Before using this software, you should have created the database, which can have any name, and ran the MySQL.SQL file script located in the SteemItPostRetriever folder to create the table that will store your posts summaries. 

To show the posts summaries on your website, edit the SteemitPosts.php, located in the SteemItPostRetriever folder, changing the MySQL Information to match your MySQL Server address and credentials and upload it to your web server. You must have PHP installed on your web server for this script to run.


Demo Page: https://moisescardona.me/SteemitPosts.php  

The PHP can be integrated into drupal. You just have to copy and paste the SteemitPosts.php file content into a new basic page in drupal and use the PHP code text format. For a demo on how the page looks on drupal, take a look at http://moisescardona.me. It is possible that the actual font vary depending on the theme you're using.

That's all! 
Enjoy showing your Steemit posts on your website!

## Updates
v1.2 (3/4/2017) 
-Added Spanish Language 

v1.1  
-Allows showing or hiding Resteemed posts on a website.

## How to Update

To show or hide resteemed posts on your website, a new table "options" must be created, and the "posts" table must be updated to include the "resteemed" column. The easiest way to update your MySQL database is to drop the "posts" table and rerun the MySQL.SQL script. This will create the updated "posts" table along with the new "options" table. Once the Database has been updated, upload the updated SteemitPosts.php file, replacing your existing SteemitPosts.php file on your server.

To repopulate the database with your posts, just run the software and check whether to show or hide Resteemed posts. If you don't have any resteemed posts, the option will not have any effect and your posts will be shown as usual.

---------------------
Do you like this software? Support me by donating some Bitcoin, Gridcoin, Burstcoin or STEEM:

Bitcoin: 1CmuQdbwwgM9TnyuqNLjk7eeVhCoFbuuM3  
Gridcoin: SAw6dAHTe2oZQTkLGCRjakB5pyHBu8hsAy  
Burstcoin: BURST-SRQE-UY26-2H7P-GNX89  
STEEM: @moisesmcardona

Software written by: Moises Cardona
