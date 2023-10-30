﻿<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    <style>
        .title {
            font-size: 20px;
            float: left;
        }

        .checkout-btn {
            float: right;
        }

        .close-button {
            float: right;
        }

        .continueshopping-btn {
            float: left;
        }

        .header {
            display: flex;
            justify-content: space-between;
            background-color: black;
            padding: 5px;
        }
    </style>
</head>

<body>

    <fieldset id="giohang-fieldset" style="width:auto; height:auto"

        <div id="cart">
            <ul id="cart-items"></ul>
            <div class="header">

                <h2 class="title" style="background-color:black; color:white; width:auto">
                    GIỎ HÀNG
                </h2>
                <a onclick="showcart"></a>

                <h2><button class="close-button" style="color:white; background-color:black" align="right">X</button></h2>
            </div>
            <ul id="cart-items"></ul>
            <table border="0">
                <tr>
                    <th style="width:15%">
                        <p id="stt">STT</p>

                    <th style="width:25%">

                        <p id="tensp">Tiêu đề</p>
                    </th>
                    <th>
                       Giá
                        <input type="number" id="gia" readonly />
                    </th>
                    <th>
                        Số lượng
                        <input type="number" id="sl"  min="1" max="50" step="1" value="1 " maxlength="4" required
                               onkeyup="tt.value=parseFloat(dg.value)*parseFloat(sl.value);"
                               onchange="tt.value=parseFloat(dg.value)*parseFloat(sl.value);" />
                    </th>
                    <th>
                        Tổng cộng
                        <input type="number" id="tt" readonly />
                    </th>
                </tr>

            </table>
            <button class="continueshopping-btn" style="background-color:gainsboro; color:black">TIẾP TỤC MUA HÀNG </button>
            <button class="checkout-btn" style="background-color:forestgreen; color:white">THANH TOÁN ĐẶT HÀNG</button>
        </div>

    </fieldset>

    <script src="Scripts/JavaScript.js"></script>
    <div>
        @RenderBody()
    </div>
</body>
</html>
