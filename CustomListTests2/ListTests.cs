using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void Add_2Values_ToList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value1 = 16;
                int value2 = 30;

                //Act
                myList.Add(value1);
                myList.Add(value2);          //this add method is in the CustomList



                //Assert

                Assert.AreEqual(16, myList[0]);

            }

            [TestMethod]
            public void Add_3Values_ToList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value1 = 16;
                int value2 = 30;
                int value3 = 22;
                //Act
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);



                //Assert

                Assert.AreEqual(22, myList[2]);

            }

            [TestMethod]
            public void Add_4Values_ToList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value1 = 16;
                int value2 = 30;
                int value3 = 22;
                int value4 = 41;
                int expected = 4;
                int actual;


                //Act
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Add(value4);

                actual = myList.Count;


                //Assert

                Assert.AreEqual(expected, actual);

            }



            [TestMethod]
            public void Add_6Values_ToList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value1 = 16;
                int value2 = 30;
                int value3 = 22;
                int value4 = 41;
                int value5 = 11;
                int value6 = 50;


                //Act
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Add(value4);
                myList.Add(value5);
                myList.Add(value6);
                myList.Remove(value1);

                //Assert

                Assert.AreEqual(30, myList[0]);

            }


            [TestMethod]
            public void Add_7Values_ToList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value1 = 16;
                int value2 = 30;
                int value3 = 22;
                int value4 = 41;
                int value5 = 11;
                int value6 = 50;
                int value7 = 80;


                //Act
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Add(value4);
                myList.Add(value5);
                myList.Add(value6);
                myList.Add(value7);

                //Assert

                Assert.AreEqual(80, myList[6]);

            }


            //////////////////////////////////////////////////////////////////////


            [TestMethod]

            public void Remove_1Value_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2 };


                //Act
                myList.Remove(1);


                //Assert

                Assert.AreEqual(2, myList[0]);

            }

            [TestMethod]

            public void Remove_2Values_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3 };


                //Act
                myList.Remove(1);
                myList.Remove(2);


                //Assert

                Assert.AreEqual(3, myList[0]);

            }


            [TestMethod]

            public void Remove_3Values_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4 };
                int expected = 1;
                int actual;


                //Act
                myList.Remove(1);
                myList.Remove(2);
                myList.Remove(3);
                actual = myList.Count;

                //Assert

                Assert.AreEqual(1, myList[0]);

            }

            [TestMethod]

            public void Remove_4Values_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5 };
                int value1 = 6;



                //Act
                myList.Remove(1);
                myList.Remove(2);
                myList.Remove(3);
                myList.Remove(4);
                myList.Remove(5);
                myList.Add(value1);


                //Assert

                Assert.AreEqual(6, myList[1]);

            }

            //[TestMethod]

            //public void Remove_5Values_FromList()
            //{
            //    //Arrange
            //    CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };


            //    //Act
            //    myList.Remove(1);
            //    myList.Remove(2);
            //    myList.Remove(3);
            //    myList.Remove(4);
            //    myList.Remove(5);

            //    //Assert

            //    Assert.AreEqual(6, myList[0]);

            //}

            [TestMethod]

            public void Remove_Last_Value_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };


                //Act
                myList.Remove(6);

                //Assert

                Assert.AreEqual(5, myList[4]);

            }

            /////////////////////////////////////////////////////////////////////


            [TestMethod]

            public void Get_Count_OfList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1 };
                int expected = 1;
                int actual;

                //Act
                actual = myList.Count;

                //Assert

                Assert.AreEqual(expected, actual);

            }

            [TestMethod]

            public void Get_Count_OfList2()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5 };
                int expected = 5;
                int actual;

                //Act
                actual = myList.Count;

                //Assert

                Assert.AreEqual(expected, actual);

            }

            [TestMethod]

            public void Get_Count_OfList3()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int expected = 9;
                int actual;

                //Act
                myList.Remove(10);
                actual = myList.Count();

                //Assert

                Assert.AreEqual(expected, actual);

            }


            [TestMethod]

            public void Get_Count_OfList5()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4, 5 };
                int expected = 6;
                int actual;

                //Act
                myList.add(6);
                actual = myList.Count;

                //Assert

                Assert.AreEqual(expected, actual);

            }

            ///////////////////////////////////////////////////////////////////


            [TestMethod]

            public void Get_String_FromList()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1 };
                string expected = "1";
                string actual;


                //Act
                actual = myList.ToString();


                //Assert
                Assert.AreEqual(expected, actual);


            }

            [TestMethod]

            public void Get_String_FromList2()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2 };
                string expected = "1 2";
                string actual;


                //Act
                actual = myList.ToString();


                //Assert
                Assert.AreEqual(expected, actual);


            }

            [TestMethod]

            public void Get_String_FromList3()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3 };
                string expected = "1 2 3";
                string actual;


                //Act
                actual = myList.ToString();


                //Assert
                Assert.AreEqual(expected, actual);


            }

            [TestMethod]

            public void Get_String_FromList4()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3 };
                string expected = "1 2 3";
                string actual;


                //Act
                actual = myList.ToString();


                //Assert
                Assert.AreEqual(expected, actual);


            }

            [TestMethod]

            public void Get_String_FromList3()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>() { 1, 2, 3 };
                string expected = "1 2 3";
                string actual;


                //Act
                actual = myList.ToString();


                //Assert
                Assert.AreEqual(expected, actual);


            }
            ///////////////////////////////////////////////////////////////////


            [TestMethod]

            public void Zip_TwoLists()
            {
                //Arrange
                CustomList<int> myList1 = new CustomList<int>() { 1, 3 };
                CustomList<int> myList2 = new CustomList<int>() { 2, 4 };
                CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4 };
                CustomList<int> actual;


                //Act
                actual = myList1.Zip(myList2);


                //Assert
                Assert.AreEqual(expected, actual);

            }


            public void Zip_TwoLists2()
            {
                //Arrange
                CustomList<int> myList1 = new CustomList<int>() { 1, 3, 5 };
                CustomList<int> myList2 = new CustomList<int>() { 2, 4 };
                CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5 };
                CustomList<int> actual;


                //Act
                actual = myList1.Zip(myList2);


                //Assert
                Assert.AreEqual(expected, actual);

            }

            public void Zip_TwoLists2()
            {
                //Arrange
                CustomList<int> myList1 = new CustomList<int>() { 1, 3, 4, 5 };
                CustomList<int> myList2 = new CustomList<int>() { 2 };
                CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5 };
                CustomList<int> actual;


                //Act
                actual = myList1.Zip(myList2);


                //Assert
                Assert.AreEqual(expected, actual);

            }







        }
    }
}
