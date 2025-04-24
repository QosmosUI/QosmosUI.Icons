// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPublons : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0 0v24h24V0zm10.34 5.1c.083.014.114.096.156.158.054.354.1.71.154 1.065.157-.162.31-.328.49-.464.867-.666 2.05-.94 3.11-.63.72.21 1.315.72 1.756 1.316.187.263.348.547.45.855.198.582.225 1.206.198 1.815-.053 1.12-.433 2.244-1.169 3.103a4.029 4.029 0 01-2.616 1.41 4.418 4.418 0 01-2.188-.317c.019 1.01.032 2.018.038 3.028.021.465-.021.938.087 1.396.031.14.123.292.28.308.302.036.608.013.912.02.057 0 .13.037.126.101.004.186.009.373-.004.56-.046.092-.17.07-.255.072a44.358 44.358 0 00-4.437 0l-.07-.056c-.004-.22-.063-.467.034-.671.3-.035.606.02.904-.032.191-.048.268-.26.295-.434.04-.32.027-.642.042-.963V8.348c0-.156.006-.31-.008-.465a.888.888 0 00-.34-.656c-.203-.158-.438-.265-.662-.388-.082-.052-.181-.097-.229-.187a.985.985 0 01.008-.337c.056-.066.144-.086.219-.122.73-.315 1.456-.636 2.185-.952.17-.068.346-.144.533-.144zm1.99 1.146c-.053 0-.104 0-.156.013a2.12 2.12 0 00-1.493.86c.005 1.44 0 2.88.003 4.32.005.327.073.676.302.924.524.512 1.302.692 2.014.593.577-.096 1.037-.538 1.279-1.054.344-.736.395-1.571.335-2.371-.053-.655-.181-1.312-.449-1.915-.184-.407-.442-.793-.811-1.054a1.717 1.717 0 00-1.024-.313z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
