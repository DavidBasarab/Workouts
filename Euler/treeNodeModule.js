function Node(value) {
    this.value = value;
    this.left = null;
    this.right = null;
}

Node.prototype.addLeft = function (value) {
    this.left = new Node(value);
}

Node.prototype.addRight = function (value) {
    this.right = new Node(value);
}

Node.prototype.sumLeft = function (value) {

}

Node.prototype.sumRight = function(value) {
    
}

module.exports = Node;