import { createRouter, createWebHashHistory } from "vue-router";

import NavBar from "./components/NavBar/NavBar.vue";
import App  from "./App.vue";
import Cart from "./components/Cart.vue";
import { cartStore } from "./stores/cart";
import Home from "./components/Home.vue";
import Rackets from "./components/Rackets/Rackets.vue";
import TestPage from "./components/TestPage.vue";


const router = createRouter({
    history: createWebHashHistory(),
    routes:  [
        {path:'/', component: Home },
        {path:'/cart', component: Cart },
        {path:'/rackets', component: Rackets },
        {path: '/test-page', component: TestPage}
        
    ]
});

router.beforeEach((to) => {
    const store = cartStore()
});

export default router;