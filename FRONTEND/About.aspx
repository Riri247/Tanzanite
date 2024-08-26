<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FRONTEND.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
/*---------------------
  Anime Details
-----------------------*/

.anime-details {
	padding-top: 60px;
}

.anime__details__content {
	margin-bottom: 65px;
}

.anime__details__text {
	position: relative;
}

.anime__details__text p {
	color: #b7b7b7;
	font-size: 18px;
	line-height: 30px;
}

.anime__details__pic {
	height: 440px;
	border-radius: 5px;
	position: relative;
}

.anime__details__pic .comment {
	font-size: 13px;
	color: #ffffff;
	background: #3d3d3d;
	display: inline-block;
	padding: 2px 10px;
	border-radius: 4px;
	position: absolute;
	left: 10px;
	bottom: 25px;
}

.anime__details__pic .view {
	font-size: 13px;
	color: #ffffff;
	background: #3d3d3d;
	display: inline-block;
	padding: 2px 10px;
	border-radius: 4px;
	position: absolute;
	right: 10px;
	bottom: 25px;
}

.anime__details__title {
	margin-bottom: 20px;
}

.anime__details__title h3 {
	color: #ffffff;
	font-weight: 700;
	margin-bottom: 13px;
}

.anime__details__title span {
	font-size: 15px;
	color: #b7b7b7;
	display: block;
}

.anime__details__rating {
	text-align: center;
	position: absolute;
	right: 0;
	top: 0;
}

.anime__details__rating .rating i {
	font-size: 24px;
	color: #e89f12;
	display: inline-block;
}

.anime__details__rating span {
	display: block;
	font-size: 18px;
	color: #b7b7b7;
}

.anime__details__widget {
	margin-bottom: 15px;
}

.anime__details__widget ul {
	margin-bottom: 20px;
}

.anime__details__widget ul li {
	list-style: none;
	font-size: 15px;
	color: #ffffff;
	line-height: 30px;
	position: relative;
	padding-left: 18px;
}

.anime__details__widget ul li:before {
	position: absolute;
	left: 0;
	top: 12px;
	height: 6px;
	width: 6px;
	background: #b7b7b7;
	content: "";
}

.anime__details__widget ul li span {
	color: #b7b7b7;
	width: 115px;
	display: inline-block;
}

.anime__details__btn .follow-btn {
	font-size: 13px;
	color: #ffffff;
	background: #e53637;
	display: inline-block;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	padding: 14px 20px;
	border-radius: 4px;
	margin-right: 11px;
}

.anime__details__btn .watch-btn span {
	font-size: 13px;
	color: #ffffff;
	background: #e53637;
	display: inline-block;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	padding: 14px 20px;
	border-radius: 4px 0 0 4px;
	margin-right: 1px;
}

.anime__details__btn .watch-btn i {
	font-size: 20px;
	display: inline-block;
	background: #e53637;
	padding: 11px 5px 16px 8px;
	color: #ffffff;
	border-radius: 0 4px 4px 0;
}

.anime__details__review {
	margin-bottom: 55px;
}

.anime__review__item {
	overflow: hidden;
	margin-bottom: 15px;
}

.anime__review__item__pic {
	float: left;
	margin-right: 20px;
	position: relative;
}

.anime__review__item__pic:before {
	position: absolute;
	right: -30px;
	top: 15px;
	border-top: 15px solid transparent;
	border-left: 15px solid #1d1e39;
	content: "";
	-webkit-transform: rotate(45deg);
	-ms-transform: rotate(45deg);
	transform: rotate(45deg);
}

.anime__review__item__pic img {
	height: 50px;
	width: 50px;
	border-radius: 50%;
}

.anime__review__item__text {
	overflow: hidden;
	background: #1d1e39;
	padding: 18px 30px 16px 20px;
	border-radius: 10px;
}

.anime__review__item__text h6 {
	color: #ffffff;
	font-weight: 700;
	margin-bottom: 10px;
}

.anime__review__item__text h6 span {
	color: #b7b7b7;
	font-weight: 400;
}

.anime__review__item__text p {
	color: #b7b7b7;
	line-height: 23px;
	margin-bottom: 0;
}

.anime__details__form form textarea {
	width: 100%;
	font-size: 15px;
	color: #b7b7b7;
	padding-left: 20px;
	padding-top: 12px;
	height: 110px;
	border: none;
	border-radius: 5px;
	resize: none;
	margin-bottom: 24px;
}

.anime__details__form form button {
	font-size: 11px;
	color: #ffffff;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	background: #e53637;
	border: none;
	padding: 10px 15px;
	border-radius: 2px;
}

    	.container {
    	background: #596e79; 
		}
    </style>

    <!-- Anime Section Begin -->
    <section class="anime-details spad">
        <div class="container">
            <div class="anime__details__content">
                <div class="row">
                    <div class="col-lg-3">
                        <div class="anime__details__pic set-bg">
							<img src="hero-1.jpg">
                            <div class="comment"><i class="fa fa-comments"></i> 11</div>
                            <div class="view"><i class="fa fa-eye"></i> 9141</div>
                        </div>
                    </div>
                    <div class="col-lg-9">
                        <div class="anime__details__text">
                            <div class="anime__details__title">
                                <h3>Fate Stay Night: Unlimited Blade</h3>
                                <span>フェイト／ステイナイト, Feito／sutei naito</span>
                            </div>
                            <div class="anime__details__rating">
                                <div class="rating">
                                    <a href="#"><i class="fa fa-star"></i></a>
                                    <a href="#"><i class="fa fa-star"></i></a>
                                    <a href="#"><i class="fa fa-star"></i></a>
                                    <a href="#"><i class="fa fa-star"></i></a>
                                    <a href="#"><i class="fa fa-star-half-o"></i></a>
                                </div>
                                <span>1.029 Votes</span>
                            </div>
                            <p>Every human inhabiting the world of Alcia is branded by a “Count” or a number written on
                                their body. For Hina’s mother, her total drops to 0 and she’s pulled into the Abyss,
                                never to be seen again. But her mother’s last words send Hina on a quest to find a
                            legendary hero from the Waste War - the fabled Ace!</p>
                            <div class="anime__details__widget">
                                <div class="row">
                                    <div class="col-lg-6 col-md-6">
                                        <ul>
                                            <li><span>Type:</span> TV Series</li>
                                            <li><span>Studios:</span> Lerche</li>
                                            <li><span>Date aired:</span> Oct 02, 2019 to ?</li>
                                            <li><span>Status:</span> Airing</li>
                                            <li><span>Genre:</span> Action, Adventure, Fantasy, Magic</li>
                                        </ul>
                                    </div>
                                    <div class="col-lg-6 col-md-6">
                                        <ul>
                                            <li><span>Scores:</span> 7.31 / 1,515</li>
                                            <li><span>Rating:</span> 8.5 / 161 times</li>
                                            <li><span>Duration:</span> 24 min/ep</li>
                                            <li><span>Quality:</span> HD</li>
                                            <li><span>Views:</span> 131,541</li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="anime__details__btn">
                                <a href="#" class="follow-btn"><i class="fa fa-heart-o"></i> Follow Renter</a>
                                <a href="#" class="watch-btn"><span>Add to cart</span> <i
                                    class="fa fa-angle-right"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                  
                   
                </div>
            </div>
        </section>
        <!-- Anime Section End -->
</asp:Content>
