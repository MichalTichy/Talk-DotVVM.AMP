1. Advantages and disadvantages of everything in single language.
    - lower speed + SEO problems vs single language/application.
2. DotVVM does a lot of stuff even for small pages.
    - quick overview of everything which has to be done before the page is served to client.
    - client vs server rendering mention.
3. Our end goal
    - complex pages without any limitations (even with small performance hit) - 🌳
    - no need to rewrite existing DotVVM code - 🌳
    - blazing fast presentation pages - ⚡
    - great SEO - ⚡    
    - single application for complex pages and simple presentation pages. 🌳 + ⚡
3. AMP
    - What it is
        - it is **really** fast
            - median 1 sec (4x faster than normal pages)
            - it's possible to have **instant** page load
        - it's not google product - but google will definitely not penalize you SEO for using it 
    - How does it work
        - AMP fremework
        - AMP infrastructure
    - limitations
4. DotVVM.AMP
    - What it is
        - fully automatic conversion of simple pages
            - snippet of registration code
        - creates AMP version of DotVVM pages which lives alongside original page
        - limitations
            - no postbacks allowed
            - No external JS allowed
            - All CSS (after inlining and aggresive optimalization) under 75 kB
            - No !important in CSS


        - What if my landing page does not fullwill those criteria
            - amp include / exclude annotations 
    - Demo
        - quick showdown of demo app
            - simple page
            - simple page with complex (incompatible) element
            - complex page
                - would not have amp version
        - mention pain points
            - CSS needs to be inlined
            - everything needs to be rendered on server
            - images need dimensions
        - process of adding DotVVM.AMP
            - registration + configuration (start with error everything mode?)
            - route configuration
            - simple page works without a hitch
                - show in AMP validator
            - more complex page does not work (throws error)
                - show that mode where AMP removes (and logs) incompatible elements
                - fix via AMP exclude
            - complex page
                - show that only DotVVM version exists
                - show redirects between AMP version and normal version (seemless experience)
    - How does it work
        - summary of how DotVVM works
        - summary of what parts we need to change for AMP conversion
        - quick overview of AMP inner workings