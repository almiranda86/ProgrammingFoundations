function GCD(a, b){ 

    if(b === 0){
        return a;
    }else{
        var r = a % b;
        return GCD(b, r);
    }
}


console.log(GCD(60, 96))
//result shoul be 12

console.log(GCD(20, 8))
//result shoul be 4