﻿using consolewithdb;
//day4 d4 = new();
///d4.CheckConnection();
// d4.CreateTable();
// d4.InsertData("");
// d4.GetData();
// d4.updateDate();
// d4.GetData();
crud cr1 = new crud();
//cr1.create_table();
//cr1.insert_data("Ram","ktm");
/*  cr1.insertdata();
  cr1.showdata();
  cr1.updateDate();
  cr1.showdata();
  cr1.deletedata();
  cr1.showdata();
*/
Class1 c1 = new Class1();
c1.checkconnection();
//c1.createtable();
c1.insert_data();
c1.select_data();
c1.update();
c1.select_data();
Console.ReadKey();