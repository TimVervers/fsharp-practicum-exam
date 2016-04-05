//This is the code file which contains code
module CodeFile

//A codefile contains a list of strings (which form the actual code file)
let randomCode (count:int) : string [] = 
    let r = System.Random()
    
    //This should be prettier...
    let code = [|"for";"while";"if";"then";"else";"end";"i"; "!=";"==";"<>";"None";"Some";"do";"yield";"return";"23 ";"3";"switch";|]
    [|
        for i in 1..count do
            let index = r.Next(code.Length)
            yield code.[index]
    |]