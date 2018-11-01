
using System;
using myCode; //deliberatelly made two classes with the same name. So I could use namespace to resolve conflict
// also used this line so I wouldn't need to type myCode.myClass


namespace workAlready {
        class MainClass { //classes

        static void Main() {
            myClass meaninglessName = new myClass();
            myCatsCode.myClass evenLessMeaningfullName = new myCatsCode.myClass();
            evenLessMeaningfullName.justCondition();
            meaninglessName.Counter();

            if (meaninglessName.numberOfJuiceBoxes<=0 ) {
                Console.WriteLine("Hello World");
            }
        }

    }
}

namespace myCode {


    class myClass {

        public string randomString = "Orange Juice with Juicy Bits";
        public int numberOfJuiceBoxes = 10;
        public float fullnessOfCurrentBox = 0.99f; //class attributes

        public void Counter() { //class methods

            while (numberOfJuiceBoxes > 0) { //the rest of requirements
                while (fullnessOfCurrentBox > 0) {
                    fullnessOfCurrentBox -= 0.1f;
                    // Console.WriteLine(numberOfJuiceBoxes);
                }
                numberOfJuiceBoxes--;
                fullnessOfCurrentBox=1;
            }

        }

    }

}

namespace myCatsCode {

    class myClass {


        public bool justCondition() { //class method
            
            if (true) { //just something to stuff into
                return false;
            }
        }
    }


}





// namespace myCatsCode {


//     class myClass {

//         // public string randomString = "Orange Juice with Juicy Bits";
//         // public int numberOfJuiceBoxes = 10;
//         // public float fullnessOfCurrentBox = 0.99f;

//         public bool noMeaning = true;

//         // static int Counter(){
//         //     if (noMeaning) {
//         //         return 1;
//         //     }
//         // }

//         static int Counter(){
//             if(true){
//                  return 1;
//             }
//         }

//     }

// }