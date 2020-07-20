<?php

    date_default_timezone_set('Asia/Kolkata'); 

    $ApiKey = <<ApiKey>>;
    $ApiSecretKey = <<ApiSecretKey>>;
    $AccessToken = <<AccessToken>>;
    $AccessTokenSecret = <<AccessTokenSecret>>;
	$url = "https://api.covid19india.org/v4/data.json";
 
	$client = curl_init($url);
	curl_setopt($client,CURLOPT_RETURNTRANSFER,true);
	$response = curl_exec($client);
	$confirmed = 0;
	$recovered = 0;
	$tested = 0;
	$deceased = 0;
 
	$result = json_decode($response,true);

	print_r($result["TT"]["total"]);
	$confirmed =  $result["TT"]["total"]["confirmed"];
	$recovered =  $result["TT"]["total"]["recovered"];
	$deceased  =  $result["TT"]["total"]["deceased"];
	$tested    =  $result["TT"]["total"]["tested"];

    // add the codebird library
    require_once('codebird/src/codebird.php');
    \Codebird\Codebird::setConsumerKey($ApiKey, $ApiSecretKey);
    $cb = \Codebird\Codebird::getInstance();
    $cb->setToken($AccessToken, $AccessTokenSecret);
	
	$date = date('d-m-y h:i:s');
	$status = "COVID19 - India Update At " . $date . "\n \n";
	$status .= "Active Cases : " . ($confirmed - $recovered) . "\n";
	$status .= "Total Cases : " . $confirmed . "\n";
	$status .= "Recovered : " . $recovered . "\n";
	$status .= "Deceased : " . $deceased . "\n";
	$status .= "Total Tested : " . $tested . "\n";
	$reply = $cb->statuses_update('status=' . urlencode($status));

?>
