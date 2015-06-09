


<!DOCTYPE html>
<html lang="en" class=" is-copy-enabled">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>portsmouth2015/Unity Project/Assets/Code/NPC.cs at master · Kierz/portsmouth2015</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="Kierz/portsmouth2015" name="twitter:title" /><meta content="portsmouth2015 - Portsmouth Game Jam 2015" name="twitter:description" /><meta content="https://avatars3.githubusercontent.com/u/6813926?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars3.githubusercontent.com/u/6813926?v=3&amp;s=400" property="og:image" /><meta content="Kierz/portsmouth2015" property="og:title" /><meta content="https://github.com/Kierz/portsmouth2015" property="og:url" /><meta content="portsmouth2015 - Portsmouth Game Jam 2015" property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/OTA5MDI1NDpmNWUzYjM4YTY0NTVjNzlhMjIwYTViYTEzNWZkNTNlMjo1NWE2YzRjNjY2NTk1MmZhYjBlZDgyNjRjZDU2N2FiMjk4NzI3YjNjOTk4Y2FmMDA3OGNiNmQ5N2NhZGU4NDdk--558bd69341e7994b9f46548931bf00021e5fac8b">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="569428B1:06C2:A4FF190:55775723" name="octolytics-dimension-request_id" /><meta content="9090254" name="octolytics-actor-id" /><meta content="hyriar" name="octolytics-actor-login" /><meta content="6a0792f0043fa2b7dd51fbfa975132bd3b3fc197426b2f41da4f4919abc26e04" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#blame" name="analytics-event" />
    <meta class="js-ga-set" name="dimension1" content="Logged In">
    <meta class="js-ga-set" name="dimension2" content="Header v3">
    <meta name="is-dotcom" content="true">
      <meta name="hostname" content="github.com">
    <meta name="user-login" content="hyriar">

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="Ln4GRSexDn35IivKCdyP2EI3riK3Djeuu1W3X6ulbtVZ9cU2TrgDYJtbNh2QJyZZTWS2K/cFhsLvAs0XN0boMg==" name="csrf-token" />

    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github/index-6967b378b26829cc5a2ea2ad4209ff0af50f2a65057962219dc9dcf8942683f0.css" media="all" rel="stylesheet" />
    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github2/index-b40381db300f2082f8a43a4e9ef68b5cb6ce498c94fdf12393a7070f3ba3eda4.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="d73d956610fae25c640e2dc4da6be3a2">

      
  <meta name="description" content="portsmouth2015 - Portsmouth Game Jam 2015">
  <meta name="go-import" content="github.com/Kierz/portsmouth2015 git https://github.com/Kierz/portsmouth2015.git">

  <meta content="6813926" name="octolytics-dimension-user_id" /><meta content="Kierz" name="octolytics-dimension-user_login" /><meta content="37061121" name="octolytics-dimension-repository_id" /><meta content="Kierz/portsmouth2015" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="37061121" name="octolytics-dimension-repository_network_root_id" /><meta content="Kierz/portsmouth2015" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/Kierz/portsmouth2015/commits/master.atom" rel="alternate" title="Recent Commits to portsmouth2015:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      


        <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/Kierz/portsmouth2015/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/Kierz/portsmouth2015/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <label class="js-chromeless-input-container form-control">
    <div class="scope-badge">This repository</div>
    <input type="text"
      class="js-site-search-focus js-site-search-field is-clearable chromeless-input"
      data-hotkey="s"
      name="q"
      placeholder="Search"
      data-global-scope-placeholder="Search GitHub"
      data-repo-scope-placeholder="Search"
      tabindex="1"
      autocapitalize="off">
  </label>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
          <li class="header-nav-item explore">
            <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
          </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
            </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
            </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
          </li>
      </ul>

      
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/hyriar" data-ga-click="Header, go to profile, text:username">
      <img alt="@hyriar" class="avatar" height="20" src="https://avatars2.githubusercontent.com/u/9090254?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">hyriar</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="/new" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu">
        
<li>
  <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
</li>
<li>
  <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
</li>


  <li class="dropdown-divider"></li>
  <li class="dropdown-header">
    <span title="Kierz/portsmouth2015">This repository</span>
  </li>
    <li>
      <a href="/Kierz/portsmouth2015/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
    </li>

      </ul>
    </div>
  </li>

  <li class="header-nav-item">
      <span class="js-socket-channel js-updatable-content"
        data-channel="notification-changed:hyriar"
        data-url="/notifications/header">
      <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
          <span class="mail-status all-read"></span>
          <span class="octicon octicon-inbox"></span>
</a>  </span>

  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="g6n+HGJtZwx6LUtykdd0nE9pdnV/4Wo4wcNVxvt9o48vsOHa+XBQuqMhuN1WCoKRiX++pkV5Cusr1vtubJvQ1w==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>



    
  </div>
</div>

        

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">

        
<ul class="pagehead-actions">

  <li>
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="QPsZ7C9lw6AKX/ED4UfKAL/clHMxKIR9jXQtWdZpy7lTLhMW3QvpKwW/C/wKXuRyXN2idnROZCz86L8ktNS0Hw==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="37061121" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/Kierz/portsmouth2015/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#blame">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Unwatch
          </span>
        </a>
        <a class="social-count js-social-count" href="/Kierz/portsmouth2015/watchers">
          4
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/Kierz/portsmouth2015/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="JUPdGDETq2qnDpBjNFt4vDi5Bm5lCRBKcOsc+b+VqKEJ4KEq6Cc5CTtV/IUPT4T5ncfSeNheRIfG2XbseFQNCg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar Kierz/portsmouth2015"
        data-ga-click="Repository, click unstar button, action:blob#blame; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/Kierz/portsmouth2015/stargazers">
          0
        </a>
</form>
    <form accept-charset="UTF-8" action="/Kierz/portsmouth2015/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="hM4cKzvfqMH3Qf1n4lpXTlrnd/32LVtX5OIQpEfVQrTT6Z98coin4zNlXJKenA72t0DdCYDkY/SCxcPjXuHfAg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star Kierz/portsmouth2015"
        data-ga-click="Repository, click star button, action:blob#blame; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/Kierz/portsmouth2015/stargazers">
          0
        </a>
</form>  </div>

  </li>

        <li>
          <a href="#fork-destination-box" class="btn btn-sm btn-with-count"
              title="Fork your own copy of Kierz/portsmouth2015 to your account"
              aria-label="Fork your own copy of Kierz/portsmouth2015 to your account"
              rel="facebox"
              data-ga-click="Repository, show fork modal, action:blob#blame; text:Fork">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/Kierz/portsmouth2015/network" class="social-count">3</a>

          <div id="fork-destination-box" style="display: none;">
            <h2 class="facebox-header">Where should we fork this repository?</h2>
            <include-fragment src=""
                class="js-fork-select-fragment fork-select-fragment"
                data-url="/Kierz/portsmouth2015/fork?fragment=1">
              <img alt="Loading" height="64" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-128-338974454bb5c32803e82f601beb051d373744b024fe8742a76009700fd7e033.gif" width="64" />
            </include-fragment>
          </div>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/Kierz" class="url fn" itemprop="url" rel="author"><span itemprop="title">Kierz</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/Kierz/portsmouth2015" data-pjax="#js-repo-pjax-container">portsmouth2015</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/Kierz/portsmouth2015/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/Kierz/portsmouth2015" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /Kierz/portsmouth2015">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/Kierz/portsmouth2015/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /Kierz/portsmouth2015/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/Kierz/portsmouth2015/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /Kierz/portsmouth2015/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Wiki">
        <a href="/Kierz/portsmouth2015/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g w" data-selected-links="repo_wiki /Kierz/portsmouth2015/wiki">
          <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>
  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/Kierz/portsmouth2015/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /Kierz/portsmouth2015/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/Kierz/portsmouth2015/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /Kierz/portsmouth2015/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                  
<div class="js-clone-url clone-url open"
  data-protocol-type="http">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/Kierz/portsmouth2015.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="ssh">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:Kierz/portsmouth2015.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="subversion">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/Kierz/portsmouth2015" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<div class="clone-options">You can clone with
  <form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="yAM6pYRPtJM0Babrgd5SX92GnFVr59y7F7WkiQA7jfYy/ljSjmnmNPATjiMMZN6EEtQBPK3ByrQzkajA1WRb5w==" /></div><button class="btn-link js-clone-selector" data-protocol="http" type="submit">HTTPS</button></form>, <form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="u+0vSU1a6G5y9A9Q8nairDm5cfj8c5m1HVmv1zy/2ZDVs4u8CC5Xd6KH2WpqJSACpOW42Ijcw9xoy6NGZVoetw==" /></div><button class="btn-link js-clone-selector" data-protocol="ssh" type="submit">SSH</button></form>, or <form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="YrGZS9/YZQlU8ip9J5dj8qhP/FJTbqq1X8yPMdsbHGUJqwnroUSBX1hxRNwGnA63pwLo2PwrDbVHbgAWChPesQ==" /></div><button class="btn-link js-clone-selector" data-protocol="subversion" type="submit">Subversion</button></form>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</div>


  <a href="github-windows://openRepo/https://github.com/Kierz/portsmouth2015" class="btn btn-sm sidebar-button" title="Save Kierz/portsmouth2015 to your computer and use it in GitHub Desktop." aria-label="Save Kierz/portsmouth2015 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>


                <a href="/Kierz/portsmouth2015/archive/master.zip"
                   class="btn btn-sm sidebar-button"
                   aria-label="Download the contents of Kierz/portsmouth2015 as a zip file"
                   title="Download the contents of Kierz/portsmouth2015 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>

          
<a href="/Kierz/portsmouth2015/blame/85e27ee6cef4cff3c4274d99a516654a4a9b2fa1/Unity%20Project/Assets/Code/NPC.cs" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<div class="breadcrumb css-truncate blame-breadcrumb js-zeroclipboard-container">
  <span class="css-truncate-target js-zeroclipboard-target"><span class="repo-root js-repo-root"><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Kierz/portsmouth2015" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">portsmouth2015</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Kierz/portsmouth2015/tree/master/Unity%20Project" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Unity Project</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Kierz/portsmouth2015/tree/master/Unity%20Project/Assets" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Assets</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Kierz/portsmouth2015/tree/master/Unity%20Project/Assets/Code" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Code</span></a></span><span class="separator">/</span><strong class="final-path">NPC.cs</strong></span>
  <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
</div>

<div class="line-age-legend">
  <span>Newer</span>
  <ol>
      <li class="heat1"></li>
      <li class="heat2"></li>
      <li class="heat3"></li>
      <li class="heat4"></li>
      <li class="heat5"></li>
      <li class="heat6"></li>
      <li class="heat7"></li>
      <li class="heat8"></li>
      <li class="heat9"></li>
      <li class="heat10"></li>
  </ol>
  <span>Older</span>
</div>

<div class="file">
  <div class="file-header">
    <div class="file-actions">
      <div class="btn-group">
        <a href="/Kierz/portsmouth2015/raw/master/Unity%20Project/Assets/Code/NPC.cs" class="btn btn-sm" id="raw-url">Raw</a>
        <a href="/Kierz/portsmouth2015/blob/master/Unity%20Project/Assets/Code/NPC.cs" class="btn btn-sm js-update-url-with-hash">Normal view</a>
        <a href="/Kierz/portsmouth2015/commits/master/Unity%20Project/Assets/Code/NPC.cs" class="btn btn-sm" rel="nofollow">History</a>
      </div>
    </div>



    <div class="file-info">
      <span class="octicon octicon-file-text"></span>
      <span class="file-mode" title="File Mode">100644</span>
      <span class="file-info-divider"></span>
        36 lines (28 sloc)
        <span class="file-info-divider"></span>
      0.613 kB
    </div>
  </div>

  <div class="blob-wrapper">
    <table class="blame-container highlight data js-file-line-container">
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="6">
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-sha">6499c99</a>
            <img alt="" class="avatar blame-commit-avatar" height="32" src="https://0.gravatar.com/avatar/cfa4be8674700ba99840651070f8334e?d=https%3A%2F%2Fassets-cdn.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png&amp;r=x&amp;s=140" width="32" />
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-commit-title" title="GM added">GM added</a>
            <div class="blame-commit-meta">
              <span class="muted-link">Kierz</span> authored
              <time datetime="2015-06-09T10:25:30Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L1">1</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC1"><span class="pl-k">using</span> UnityEngine;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L2">2</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC2"><span class="pl-k">using</span> System.Collections;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L3">3</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC3"></td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L4">4</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC4"><span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">NPC</span> : <span class="pl-k">Character</span></td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L5">5</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC5">{</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="4">
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-sha">c16baf1</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T15:44:35Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L6">6</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC6">    <span class="pl-k">private</span> <span class="pl-k">int</span> health, speed;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L7">7</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC7">    <span class="pl-k">private</span> <span class="pl-k">float</span> xpos, zpos = <span class="pl-c1">0</span>;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L8">8</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC8">    <span class="pl-k">private</span> <span class="pl-k">bool</span> isDead;</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="3">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L9">9</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC9"></td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L10">10</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC10">	<span class="pl-k">void</span> <span class="pl-en">Start</span>() </td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-sha">6499c99</a>
            <img alt="" class="avatar blame-commit-avatar" height="32" src="https://0.gravatar.com/avatar/cfa4be8674700ba99840651070f8334e?d=https%3A%2F%2Fassets-cdn.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png&amp;r=x&amp;s=140" width="32" />
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-commit-title" title="GM added">GM added</a>
            <div class="blame-commit-meta">
              <span class="muted-link">Kierz</span> authored
              <time datetime="2015-06-09T10:25:30Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L11">11</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC11">    {</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="3">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L12">12</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC12">        isDead = <span class="pl-c1">false</span>;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L13">13</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC13">        health = <span class="pl-c1">1</span>;</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/d500ac1dada3b59c8816dd4539b4df3c90c0faec" class="blame-sha">d500ac1</a>
            <img alt="@Kierz" class="avatar blame-commit-avatar" height="32" src="https://avatars0.githubusercontent.com/u/6813926?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/d500ac1dada3b59c8816dd4539b4df3c90c0faec" class="blame-commit-title" title="Merge conflicts resolved - still some bugs it seems">Merge conflicts resolved - still some bugs it seems</a>
            <div class="blame-commit-meta">
              <a href="/Kierz" class="muted-link" rel="author">Kierz</a> authored
              <time datetime="2015-06-09T19:00:42Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat1"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L14">14</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC14">        xpos = Random.Range( GameManager.Singleton().GetWorldLeft(), GameManager.Singleton().GetWorldRight() );</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="3">
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-sha">c16baf1</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T15:44:35Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L15">15</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC15">        transform.position = <span class="pl-k">new</span> Vector3(xpos, <span class="pl-c1">0.0f</span>, zpos);</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L16">16</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC16"></td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="3">
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-sha">6499c99</a>
            <img alt="" class="avatar blame-commit-avatar" height="32" src="https://0.gravatar.com/avatar/cfa4be8674700ba99840651070f8334e?d=https%3A%2F%2Fassets-cdn.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png&amp;r=x&amp;s=140" width="32" />
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-commit-title" title="GM added">GM added</a>
            <div class="blame-commit-meta">
              <span class="muted-link">Kierz</span> authored
              <time datetime="2015-06-09T10:25:30Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L17">17</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC17">	}</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L18">18</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC18">	</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L19">19</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC19">    <span class="pl-k">void</span> <span class="pl-en">Update</span>() </td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-sha">6499c99</a>
            <img alt="" class="avatar blame-commit-avatar" height="32" src="https://0.gravatar.com/avatar/cfa4be8674700ba99840651070f8334e?d=https%3A%2F%2Fassets-cdn.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png&amp;r=x&amp;s=140" width="32" />
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-commit-title" title="GM added">GM added</a>
            <div class="blame-commit-meta">
              <span class="muted-link">Kierz</span> authored
              <time datetime="2015-06-09T10:25:30Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L20">20</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC20">    {</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L21">21</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC21">        <span class="pl-k">if</span> (isDead)</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-sha">c16baf1</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T15:44:35Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L22">22</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC22">            <span class="pl-k">return</span>;</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L23">23</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC23"></td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/d500ac1dada3b59c8816dd4539b4df3c90c0faec" class="blame-sha">d500ac1</a>
            <img alt="@Kierz" class="avatar blame-commit-avatar" height="32" src="https://avatars0.githubusercontent.com/u/6813926?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/d500ac1dada3b59c8816dd4539b4df3c90c0faec" class="blame-commit-title" title="Merge conflicts resolved - still some bugs it seems">Merge conflicts resolved - still some bugs it seems</a>
            <div class="blame-commit-meta">
              <a href="/Kierz" class="muted-link" rel="author">Kierz</a> authored
              <time datetime="2015-06-09T19:00:42Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat1"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L24">24</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC24">	    <span class="pl-k">if</span> (health &lt;= <span class="pl-c1">0</span>)</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="5">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L25">25</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC25">        {</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L26">26</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC26">            explode();</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L27">27</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC27">            isDead = <span class="pl-c1">true</span>;</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L28">28</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC28">        }</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-sha">c16baf1</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/c16baf1d37d3312764c44b3a7a1def223571ed93" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T15:44:35Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L29">29</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC29">    }</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="6">
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-sha">65f2d33</a>
            <img alt="@hyriar" class="avatar blame-commit-avatar" height="32" src="https://avatars1.githubusercontent.com/u/9090254?v=3&amp;s=64" width="32" />
            <a href="/Kierz/portsmouth2015/commit/65f2d334d24487554b0640d9adc3c31772793a04" class="blame-commit-title" title="Stashing">Stashing</a>
            <div class="blame-commit-meta">
              <a href="/hyriar" class="muted-link" rel="contributor">hyriar</a> authored
              <time datetime="2015-06-09T14:35:59Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L30">30</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC30"></td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L31">31</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC31">    <span class="pl-k">void</span> <span class="pl-en">explode</span>()</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L32">32</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC32">    {</td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L33">33</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC33"></td>
          </tr>
          <tr class="blame-line">
            <td class="line-age heat2"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L34">34</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC34">    }</td>
          </tr>
        <tr class="blame-commit">
          <td class="blame-commit-info" rowspan="2">
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-sha">6499c99</a>
            <img alt="" class="avatar blame-commit-avatar" height="32" src="https://0.gravatar.com/avatar/cfa4be8674700ba99840651070f8334e?d=https%3A%2F%2Fassets-cdn.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png&amp;r=x&amp;s=140" width="32" />
            <a href="/Kierz/portsmouth2015/commit/6499c99a6b0fbba780f30b3f35af5e9cd596d6cc" class="blame-commit-title" title="GM added">GM added</a>
            <div class="blame-commit-meta">
              <span class="muted-link">Kierz</span> authored
              <time datetime="2015-06-09T10:25:30Z" is="relative-time">Jun 9, 2015</time>
            </div>
          </td>
        </tr>
          <tr class="blame-line">
            <td class="line-age heat4"></td>
            <td class="blob-num blame-blob-num js-line-number" id="L35">35</td>
            <td class="blob-code blob-code-inner js-file-line" id="LC35">}</td>
          </tr>
    </table>
  </div>
</div>


        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.08837s from github-fe137-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
    </ul>
  </div>
</div>


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-68c41efebc976764e6b82e425124ad913abbe691b87d1681debeb2554e8a0d3a.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github/index-8d9ac24ecec907c7f13871519a661f464269e254cb013ea0e1bbd1be03e1605d.js"></script>
      
      
  </body>
</html>

