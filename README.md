# ipbase-dotnet

ipbase-dotnet is the official C# Wrapper around the [ipbase](https://app.ipbase.com) API.

## Configuration

You will need your apikey to use Ipbase, you can get one [https://app.ipbase.com/register](https://app.ipbase.com/register).

Create an instance and pass your api key like here:

    var fx = new Ipbase("[YOUR_API_KEY]");

## Usage & Endpoints

Use the instance to call the endpoints

#### Status
Returns your current quota

    fx.Status()

#### Info
Checks the provided ip address (both v4 & v6 formats) and returns all available information.

    fx.Info(ip, language)

  | Parameter | Data type | Mandatory | Description |
  | --- | ----------- | --- | ----------- |
  | ip | string, Path Parameter | yes | The ip address you want to query |
  | language | string | no | An ISO Alpha 2 Language Code for localising the ip data |


You can find further information on https://ipbase.com/docs/

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Added some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request

Bug reports and pull requests are welcome on GitHub at https://github.com/everapihq/ipbase-dotnet. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [code of conduct](https://github.com/everapihq/ipbase-dotnet/blob/master/CODE_OF_CONDUCT.md).

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## Code of Conduct

Everyone interacting in the Ipbase project's codebases, issue trackers, chat rooms and mailing lists is expected to follow the [code of conduct](https://github.com/everapihq/ipbase-dotnet/blob/master/CODE_OF_CONDUCT.md).
