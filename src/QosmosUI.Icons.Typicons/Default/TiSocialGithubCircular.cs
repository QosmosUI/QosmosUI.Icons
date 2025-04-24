// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiSocialGithubCircular : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 21c-4.963 0-9-4.038-9-9s4.037-9 9-9 9 4.038 9 9-4.037 9-9 9zm0-16c-3.859 0-7 3.14-7 7s3.141 7 7 7 7-3.14 7-7-3.141-7-7-7zM13.565 12.626c.171 0 .316.084.441.255.124.169.187.378.187.625 0 .248-.062.457-.187.626-.125.169-.271.254-.441.254-.181 0-.337-.084-.461-.254-.124-.169-.187-.378-.187-.626s.062-.456.187-.625c.125-.171.281-.255.461-.255m2.21-2.289c.482.522.725 1.155.725 1.898 0 .482-.057.915-.166 1.301-.111.384-.252.698-.42.939-.171.242-.378.454-.627.635-.249.184-.478.316-.685.401-.208.085-.446.15-.716.196-.266.047-.467.072-.606.079l-.44.009-.352.01-.488.011-.488-.011-.352-.01-.44-.009c-.14-.007-.341-.032-.606-.079-.271-.045-.508-.11-.716-.196-.207-.084-.436-.217-.684-.401-.25-.182-.457-.394-.628-.635-.168-.241-.309-.555-.42-.939-.109-.386-.166-.819-.166-1.301 0-.743.242-1.376.725-1.898-.053-.026-.056-.286-.008-.782.043-.496.148-.953.319-1.37.602.064 1.343.404 2.23 1.017.3-.078.71-.118 1.233-.118.549 0 .959.04 1.234.118.404-.273.791-.496 1.16-.666.374-.168.644-.267.814-.293l.254-.058c.172.417.277.875.32 1.37.05.496.047.756-.006.782m-3.754 5.027c1.083 0 1.899-.129 2.454-.39.553-.26.833-.796.833-1.605 0-.469-.176-.861-.529-1.174-.181-.17-.394-.273-.638-.313-.238-.039-.607-.039-1.104 0-.495.04-.834.058-1.016.058-.248 0-.517-.013-.851-.039l-.783-.049c-.191-.006-.395.018-.616.069-.223.053-.404.143-.55.273-.336.3-.507.691-.507 1.174 0 .809.274 1.345.821 1.605.547.261 1.361.39 2.444.39m-1.524-2.737c.17 0 .316.084.44.255.124.169.187.378.187.625 0 .248-.062.457-.187.626-.124.169-.271.254-.44.254-.182 0-.337-.084-.462-.254-.124-.169-.187-.378-.187-.626s.062-.456.187-.625c.125-.171.28-.255.462-.255");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
