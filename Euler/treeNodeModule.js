function Node(value) {
  this.value = parseInt(value);
  this.left = null;
  this.right = null;
}

Node.prototype.addLeft = function (value) {
  this.left = new Node(value);
};

Node.prototype.addRight = function (value) {
  this.right = new Node(value);
};

Node.prototype.findLargestSum = function () {

  var leftSum = 0;
  var rightSum = 0;

  if (this.left != null) {
    leftSum = this.left.findLargestSum();
  }

  if (this.right != null) {
    rightSum = this.right.findLargestSum();
  }

  var finalSum = this.value;

  if (leftSum > rightSum) {
    finalSum += leftSum;
  } else {
    finalSum += rightSum;
  }

  console.log(`Finding Largest Sum for ${this.value} | LeftValue := ${this.left == null ? 0 : this.left.value} | RightValue := ${this.right == null ? 0 : this.right.value} | FinalSum := ${finalSum}`);

  return finalSum;
};

module.exports = Node;