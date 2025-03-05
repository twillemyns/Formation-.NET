import {Customer, Order, OrderItem} from "./interfaces.js";

export function createOrder(customer: Customer, items: OrderItem[]): Order {
    return {
        id: 0,
        customer: customer,
        items: items,
        status: "En attente"
    }
}

export function calculateTotal(order: Order): number {
    let total = 0;
    order.items.forEach(item =>
        total +=  item.product.price * item.quantity
    )
    return total;
}

