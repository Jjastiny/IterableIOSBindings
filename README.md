## Synopsis

This is the iOS xamarin binding library for Iterable SDK.
## Code Example

<code>IterableAPI.SharedInstanceWithApiKey("apiKey", "email", new NSDictionary());</code>
<code>IterableAPI.SharedInstanceWithApiKey("apiKey", new NSDictionary(), "userId");</code>

## Motivation

Iterable does not provide bindings for Xamarin and objective C has some method that cannot be converted into C#. This problem was caused by Objective-C letting multiple functions have same parameter types. This binding moves the userId parameter after the NSDictionary launchOptions to avoid that problem.

## Installation

## API Reference

## Contributors

Let people know how they can dive into the project, include important links to things like issue trackers, irc, twitter accounts if applicable.

## License
      Apache License
  Version 2.0, January 2004
http://www.apache.org/licenses/
