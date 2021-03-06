function GCD(a, b){ 

    while(b != 0){
        var temp = a;
        a = b;
        b = temp % b
    }

    return a;
}


console.log(GCD(60, 96))
//result shoul be 12

console.log(GCD(20, 8))
//result shoul be 4