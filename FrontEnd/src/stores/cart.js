import { defineStore } from "pinia";
import { ref } from "vue";
export const cartStore = defineStore("cart", {
	state: () => {
		return {
			name: "Cart",
			items: ref({}),
			count: ref(0)
		}
	},

	getters: {
		cartQuantity() {
			var nr = 0;
			for (let key in this.items) {
				nr += this.items[key].quantity;
			}
			return nr;
		},
	},
	 
	actions: {
		addItem(item) {
			if (!this.items[item.id]) {
				this.items[item.id] = { 'item' :item, 'quantity': 1 };
			}
			
		},
		
		getQuantity(id)  {
			if (this.items[id]) {
				return this.items[id].quantity;
			} 
			return 0;
		},

		incQuantity(id) {
			if (this.items[id]) {
				this.items[id].quantity += 1;
			}
		},
		
		decQuantity(id) {
			if (this.items[id]) {
				if (this.items[id].quantity > 1) {
					this.items[id].quantity -= 1;
				} else {
					delete this.items[id];
				}
			}
		},

		removeItem(id) {
			if (this.items[id]) {
				delete this.items[id];
			}
		},

		contains(id) {
			if (this.items[id]) {
				return true;
			} 
			return false;
		},

		quantity() {
			var nr = 0;
			for (let x in this.items) {
				nr += this.items[x].quantity;
			}
			return nr;
		},

		priceSum() {
			var nr = 0;
			for (let x in this.items) {
				nr += this.items[x].item.price *  this.items[x].quantity;
			}
			return nr;
		}
	}
});
