<template>
	<div class="main-navbar shadow-sm sticky-top">
		<div class="top-navbar">
			<div class="container-fluid">
				<div class="row">
					<div class="col-md-2 my-auto d-none d-sm-none d-md-block d-lg-block">
						<h5 class="brand-name">{{Title}}</h5>
					</div>
					<div class="col-md-5 my-auto">
						<form role="search">
							<div class="input-group">
								<input type="search" placeholder="Search your product" class="form-control" />
								<button class="btn bg-white" type="submit">
									<i class="fa fa-search"></i>
								</button>
							</div>
						</form>
					</div>
					<div class="col-md-5 my-auto">
						<ul class="nav justify-content-end">
							
							<li class="nav-item">
								<RouterLink class="nav-link" to="/cart">
									<i class="fa fa-shopping-cart"></i> {{ cartCount }}
								</RouterLink>
							</li>
							<li class="nav-item">
								<a class="nav-link" href="#">
									<i class="fa fa-heart"></i> Wishlist (0)
								</a>
							</li>
							<li class="nav-item dropdown">
								<a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
									<i class="fa fa-user"></i> Username 
								</a>
								<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
									<li><a class="dropdown-item" href="#"><i class="fa fa-user"></i> Profile</a></li>
									<li><a class="dropdown-item" href="#"><i class="fa fa-list"></i> My Orders</a></li>
									<li><a class="dropdown-item" href="#"><i class="fa fa-heart"></i> My Wishlist</a></li>
									<li><a class="dropdown-item" href="/cart"><i class="fa fa-shopping-cart"></i> My Cart</a></li>
									<li><a class="dropdown-item" href="#"><i class="fa fa-sign-out"></i> Logout</a></li>
								</ul>
							</li>
						</ul>
					</div>
				</div>
			</div>
		</div>
		<nav class="navbar navbar-expand-lg">
			<div class="container-fluid">
				<a class="navbar-brand d-block d-sm-block d-md-none d-lg-none" href="#">
					Funda Ecom
				</a>
				<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
					<span class="navbar-toggler-icon"></span>
				</button>
				<div class="collapse navbar-collapse" id="navbarSupportedContent">
					<ul class="navbar-nav me-auto mb-2 mb-lg-0">
						<li class="nav-item">
							<a class="nav-link" href="#">Home</a>
						</li>
						<li class="nav-item">
							<RouterLink class="nav-link" to="/rackets">Rackets</RouterLink>
						</li>
						<li class="nav-item">
							<RouterLink class="nav-link" to="/test-page">Test Page</RouterLink>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Featured Products</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Electronics</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Fashions</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Accessories</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Home</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="#">Appliances</a>
						</li>
					</ul>
				</div>
			</div>
		</nav>
	</div>
</template> 
<script>

import { cartStore } from '@/stores/cart';
import DropDown from './DropDown.vue';

export default {
	components: {
		DropDown  
	},
	props: {
		data: {
			type: Array,
			required: true
		}
	},

	data() {
		return {
			Title: "Tennis Store",
			url: "@",
			cart: cartStore()
		}
	},

	computed: {
		processedData() {
			return this.data.map(category => ({
				...category,
				url: this.generateLink(category.name)
			}));
		},
		cartCount() {
			return this.cart.quantity();
		}
	},
	methods: {
		generateLink(name) {
			return '/' + name.trim().split(/\s+/).join('-');
		},
		makeProductUrl(url) {
			return "/Product" + url;
		}
	}


}


</script>


<style>
.main-navbar{
	border-bottom: 1px solid #ccc;
  }
  .main-navbar .top-navbar{
	background-color: #2874f0;
	padding-top: 10px;
	padding-bottom: 10px;
  }
  .main-navbar .top-navbar .brand-name{
	color: #fff;
  }
  .main-navbar .top-navbar .nav-link{
	color: #fff;
	font-size: 16px;
	font-weight: 500;
  }
  .main-navbar .top-navbar .dropdown-menu{
	padding: 0px 0px;
	border-radius: 0px;
  }
  .main-navbar .top-navbar .dropdown-menu .dropdown-item{
	padding: 8px 16px;
	border-bottom: 1px solid #ccc;
	font-size: 14px;
  }
  .main-navbar .top-navbar .dropdown-menu .dropdown-item i{
	width: 20px;
	text-align: center;
	color: #2874f0;
	font-size: 14px;
  }
  .main-navbar .navbar{
	padding: 0px;
	background-color: #ddd;
  }
  .main-navbar .navbar .nav-item .nav-link{
	padding: 8px 20px;
	color: #000;
	font-size: 15px;
  }
  
  @media only screen and (max-width: 600px) {
	.main-navbar .top-navbar .nav-link{
		font-size: 12px;
		padding: 8px 10px;
	}
  }

</style>