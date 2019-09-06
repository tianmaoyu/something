#javascript 中的原型连

```javascript

function Student(){
    this.name = "小马扎"; 
    this.age = 18;
}
var lilei = new Student(); 

lilei.constructor.prototype===Student.prototype;
lilei.constructor.prototype==lilei.__proto__;
//三个是相等的

```
