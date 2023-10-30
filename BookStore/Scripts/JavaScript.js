document.getElementById("giohang-fieldset").addEventListener("cart", function (event) {
    event.preventDefault();

const products = [
    { id: 1, name: "Sản phẩm 1", price: 10 },
    { id: 2, name: "Sản phẩm 2", price: 20 },
    { id: 3, name: "Sản phẩm 3", price: 30 }
];

// Lấy phần tử giỏ hàng từ DOM
const cartItemsElement = document.getElementById("cart-items");

// Hàm để thêm sản phẩm vào giỏ hàng
function addToCart(productId) {
    const product = products.find(item => item.id === productId);
    if (product) {
        const cartItem = document.createElement("li");
        cartItem.classList.add("cart-item");
        cartItem.innerHTML = `
<span>${product.name}</span>
<span>${product.price}</span>
<button onclick="removeFromCart(${product.id})">Xoá</button>
`;
        cartItemsElement.appendChild(cartItem);
    }
}

// Hàm để xoá sản phẩm khỏi giỏ hàng
function removeFromCart(productId) {
    const cartItem = document.querySelector(`.cart-item[data-id="${productId}"]`);
    if (cartItem) {
        cartItem.remove();
    }
}