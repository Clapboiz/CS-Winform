# CS-Winform
This is my small project at college

Here are the tasks that I do in this project:
- Create database and deploy it
- Create Login + Register
- RSA256 + SALT for password
- Game with AI (Use algorithm minimax)
- Design UI game

Source game: "somewhere on google that i don't remember"

When you download my project, you need to edit the connect to database link to suit your machine, namely:

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/984bd11b-d545-4249-877a-bde2f6df5f64)

Please copy the string in the box next to the connection string: "Data Source=LAPTOP-EGMVE44L\SQLEXPRESS;Initial Catalog=DATA_REGISTER;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/369a0518-537c-4e50-812d-8350ba500217)

Then you need to remove a few characters so that it looks like the string in the image below, it will work

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/f815dde1-bf07-4328-bcea-f3014f6fb342)

You may get some errors when you run this Project, for example Sakk Alkalmazás 2.0.exe can't run.
 - To solve this, you need to delete the bin and obj folders in the Ches>Game>Windowsformchess folder, then you have to download the backup folder and go to the Ches>Game>Windowsformchess folder and copy the bin and obj folders and Paste it in the folder you just deleted
  * (I think this error occurs when there is a version conflict because the game dev version is too low and the operating version of other functions is too high, or it can also be because we turned off the debug program incorrectly.)
 
Here is the procedure:

- First you have to connect 2 laptops to 1 wifi, type ipconfig on windows and ifconfig on linux, then you can copy this ip then replace the code on both client and server

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/b52687b4-cc52-48e3-b8c1-1624b61a05eb)

You go to folder chess> newchessserver -> runserver.

You start the server.

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/2ef6113e-be2d-455d-95f5-72749551ef99)

Then you go to client login or register a password account. Then you choose Lan game.

![image](https://github.com/Clapboiz/CS-Winform/assets/112185647/01d817b2-5c95-48fc-a0ca-bb0542fb3f50)

Then you click connect > create room. (This is the finished job of client A)

Then you go to machine B and enter the ID then click join.

And that's the process of setting up and playing the game

### I have uploaded a clip on here, please open it for an overview.

- And if you have any questions or suggestions for this project of mine, don't hesitate to let me know.

- Don't forget if you find this project of mine good, please give me a follow.

Best regards!






