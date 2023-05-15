﻿using System;

namespace BLL.Services
{
    public class HtmlBodyGenerator
    {
        public static string EmailBody(int orderId, DateTime date, decimal total, string email, string address)
        {
            return ($@"<!DOCTYPE html>
<html lang='en-US'>

<head>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
    <title>medicell</title>
</head>

<body leftmargin='0' marginwidth='0' topmargin='0' marginheight='0' offset='0' style='padding: 0;'>
    <div id='wrapper' dir='ltr'
        style='background-color: #f7f7f7; margin: 0; padding: 70px 0; width: 100%; -webkit-text-size-adjust: none;'
        bgcolor='#f7f7f7' width='100%'>
        <table border='0' cellpadding='0' cellspacing='0' height='100%' width='100%'>
            <tr>
                <td align='center' valign='top'>
                    <div id='template_header_image'>
                        <h1
                            style='border: none; display: inline-block; font-size: 50px; font-weight: bold; height: auto; outline: none; text-decoration: none; text-transform: capitalize; vertical-align: middle; max-width: 100%; margin-left: 0; margin-right: 0;'>
                            MediCell
                        </h1>
                    </div>
                    <table border='0' cellpadding='0' cellspacing='0' width='600' id='template_container'
                        style='background-color: #fff; border: 1px solid #dedede; box-shadow: 0 1px 4px rgba(0,0,0,.1); border-radius: 3px;'
                        bgcolor='#fff'>
                        <tr>
                            <td align='center' valign='top'>
                                <table border='0' cellpadding='0' cellspacing='0' width='100%' id='template_header'
                                    style='background-color: #111827; color: #fff; border-bottom: 0; font-weight: bold; line-height: 100%; vertical-align: middle; font-family: 'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; border-radius: 3px 3px 0 0;'
                                    bgcolor='#111827'>
                                    <tr>
                                        <td id='header_wrapper' style='padding: 36px 48px; display: block;'>
                                            <h1 style='font-family: 'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-size: 30px; font-weight: 300; line-height: 150%; margin: 0; text-align: left; text-shadow: 0 1px 0 #111827; color: #fff; background-color: inherit;'
                                                bgcolor='inherit'>Thanks for the purchase !</h1>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align='center' valign='top'>
                                <table border='0' cellpadding='0' cellspacing='0' width='600' id='template_body'>
                                    <tr>
                                        <td valign='top' id='body_content' style='background-color: #fff;'
                                            bgcolor='#fff'>
                                            <!-- Content -->
                                            <table border='0' cellpadding='20' cellspacing='0' width='100%'>
                                                <tr>
                                                    <td valign='top' style='padding: 48px 48px 32px;'>
                                                        <div id='body_content_inner'
                                                            style='color: #636363; font-family: 'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-size: 14px; line-height: 150%; text-align: left;'
                                                            align='left'>

                                                            <p style='margin: 0 0 16px;'>Hi ,</p>
                                                            <p style='margin: 0 0 16px;'>We have finished processing
                                                                your order.</p>
                                                            <p style='margin: 0 0 16px;'>Thanks for the purchase. We
                                                                will verify your payment and deliver your product.
                                                                <a href='http://localhost:3000/order/{orderId}'>Order details</a>
                                                            </p>


                                                            <h2
                                                                style='color: #111827; display: block; font-family: 'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-size: 18px; font-weight: bold; line-height: 130%; margin: 0 0 18px; text-align: left;'>
                                                                [Order #{orderId}] ({date})</h2>

                                                            <div style='margin-bottom: 40px;'>
                                                                <table class='td' cellspacing='0' cellpadding='6'
                                                                    border='1'
                                                                    style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; width: 100%; font-family: 'Helvetica Neue', Helvetica, Roboto, Arial, sans-serif;'
                                                                    width='100%'>

                                                                    <tfoot>
                                                                        <tr>
                                                                            <th class='td' scope='row' colspan='2'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left; border-top-width: 4px;'
                                                                                align='left'>Subtotal:</th>
                                                                            <td class='td'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left; border-top-width: 4px;'
                                                                                align='left'><span
                                                                                    class='woocommerce-Price-amount amount'>{total}<span
                                                                                        class='woocommerce-Price-currencySymbol'>৳
                                                                                    </span></span></td>
                                                                        </tr>
                                                                        <tr>
                                                                            <th class='td' scope='row' colspan='2'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left;'
                                                                                align='left'>Payment method:</th>
                                                                            <td class='td'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left;'
                                                                                align='left'>Cash</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <th class='td' scope='row' colspan='2'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left;'
                                                                                align='left'>Total:</th>
                                                                            <td class='td'
                                                                                style='color: #636363; border: 1px solid #e5e5e5; vertical-align: middle; padding: 12px; text-align: left;'
                                                                                align='left'><span
                                                                                    class='woocommerce-Price-amount amount'>{total}<span
                                                                                        class='woocommerce-Price-currencySymbol'>৳
                                                                                    </span></span></td>
                                                                        </tr>
                                                                    </tfoot>
                                                                </table>
                                                            </div>

                                                            <table id='addresses' cellspacing='0' cellpadding='0'
                                                                border='0'
                                                                style='width: 100%; vertical-align: top; margin-bottom: 40px; padding: 0;'
                                                                width='100%'>
                                                                <tr>
                                                                    <td valign='top' width='50%'
                                                                        style='text-align: left; font-family: 'Helvetica Neue', Helvetica, Roboto, Arial, sans-serif; border: 0; padding: 0;'
                                                                        align='left'>
                                                                        <h2
                                                                            style='color: #111827; display: block; font-family: 'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-size: 18px; font-weight: bold; line-height: 130%; margin: 0 0 18px; text-align: left;'>
                                                                            Billing address</h2>

                                                                        <address class='address'
                                                                            style='padding: 12px; color: #636363; border: 1px solid #e5e5e5;'>
                                                                            {address} <br>{email} </address>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>

</html>");
        }
    }
}