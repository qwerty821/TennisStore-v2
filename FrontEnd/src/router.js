import { createRouter, createWebHashHistory } from "vue-router";

import NavBar from "./components/NavBar/NavBar.vue";
import App  from "./App.vue";
import Cart from "./components/Cart.vue";
import { cartStore } from "./stores/cart";
import Home from "./components/Home.vue";
import Rackets from "./components/Rackets/Rackets.vue";

const router = createRouter({
    history: createWebHashHistory(),
    routes:  [
        {path:'/', component: Home },
        {path:'/cart', component: Cart },
        {path:'/rackets', component: Rackets },
        
        
        
    ]
});

router.beforeEach((to) => {
    const store = cartStore()
});

export default router;