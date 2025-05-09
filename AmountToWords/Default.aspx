<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="AmountToWords._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Amount to Words Converter</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <style>
        body {
            background-color: #f8f9fa;
        }
        .converter-card {
            max-width: 600px;
            margin: 50px auto;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        .card-header {
            background-color: #4e73df;
            color: white;
            border-radius: 10px 10px 0 0 !important;
        }
        .result-box {
            min-height: 60px;
            padding: 15px;
            margin-top: 15px;
            background-color: #f3f3f9;
            border-radius: 5px;
            border-left: 5px solid #4e73df;
        }
        .mt-4 {
            margin-top: 2rem !important;
        }
        .badge-success {
            background-color: #1cc88a;
        }
        .badge-danger {
            background-color: #e74a3b;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="card converter-card">
                <div class="card-header text-center py-3">
                    <h2 class="m-0 font-weight-bold">Amount to Words Converter</h2>
                </div>
                <div class="card-body p-4">
                    <div class="form-group mb-4">
                        <label for="txtAmount" class="form-label fw-bold">Enter an amount:</label>
                        <div class="input-group">
                            <span class="input-group-text">$</span>
                            <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control form-control-lg" placeholder="e.g. 1234.56"></asp:TextBox>
                        </div>
                        <div class="form-text text-muted">Enter a numeric value to convert it into words</div>
                    </div>
                    
                    <div class="d-grid gap-2">
                        <asp:Button ID="btnConvert" runat="server" Text="Convert to Words" OnClick="btnConvert_Click" 
                            CssClass="btn btn-primary btn-lg" />
                    </div>
                    
                    <div class="result-box">
                        <h5 class="mb-2 text-muted">Result:</h5>
                        <asp:Label ID="lblResult" runat="server" CssClass="fs-5 fw-bold text-dark"></asp:Label>
                    </div>
                </div>
                <div class="card-footer text-center text-muted py-3">
                    <small>Convert any numerical amount to its word equivalent</small>
                </div>
            </div>
            
            <div class="card converter-card mt-4">
                <div class="card-header text-center py-3">
                    <h2 class="m-0 font-weight-bold">Palindrome Number Checker</h2>
                </div>
                <div class="card-body p-4">
                    <div class="form-group mb-4">
                        <label for="txtPalindrome" class="form-label fw-bold">Enter a number:</label>
                        <asp:TextBox ID="txtPalindrome" runat="server" CssClass="form-control form-control-lg" placeholder="e.g. 12321"></asp:TextBox>
                        <div class="form-text text-muted">A palindrome reads the same backward as forward (e.g., 121, 12321)</div>
                    </div>
                    
                    <div class="d-grid gap-2">
                        <asp:Button ID="btnCheckPalindrome" runat="server" Text="Check Palindrome" OnClick="btnCheckPalindrome_Click" 
                            CssClass="btn btn-success btn-lg" />
                    </div>
                    
                    <div class="result-box">
                        <h5 class="mb-2 text-muted">Result:</h5>
                        <asp:Label ID="lblPalindromeResult" runat="server" CssClass="fs-5 fw-bold text-dark"></asp:Label>
                        <asp:Label ID="lblPalindromeBadge" runat="server" CssClass="ms-2 badge rounded-pill"></asp:Label>
                    </div>
                </div>
                <div class="card-footer text-center text-muted py-3">
                    <small>Check if a number reads the same backward as forward</small>
                </div>
            </div>
        </div>
    </form>
    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>
</html> 
