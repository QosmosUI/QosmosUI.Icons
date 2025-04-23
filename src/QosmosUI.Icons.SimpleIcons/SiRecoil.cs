// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRecoil : ComponentBase
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
		builder.AddAttribute(15, "d", "M17.09 8.862a3.017 3.018 0 00-2.615-2.43l-.245-.03a1.662 1.662 0 01-1.453-1.645v-.856a2.028 2.028 0 10-1.602-.02v.874a3.263 3.264 0 002.855 3.236l.245.032c.764.096 1.144.66 1.246 1.155.1.495-.03 1.163-.698 1.55a2.569 2.569 0 01-1.055.337l-3.68.346a4.212 4.212 0 00-1.71.546 3.02 3.02 0 00-1.468 3.257 3.017 3.018 0 002.615 2.43l.245.032a1.662 1.662 0 011.453 1.644v.777a2.03 2.03 0 101.602.016v-.793a3.263 3.264 0 00-2.856-3.236l-.244-.032c-.764-.096-1.145-.66-1.246-1.155-.1-.495.03-1.163.697-1.55a2.569 2.569 0 011.057-.337l3.68-.345a4.212 4.212 0 001.71-.546 3.023 3.024 0 001.467-3.258zm-2.653 4.708a5.71 5.71 0 01-.436.06l-1.543.147 1.93 2.119a3.47 3.47 0 01.906 2.34H16.9a5.07 5.07 0 00-1.325-3.42zm-5.003-3.11a4.65 4.65 0 01.546-.08l1.427-.136L9.469 8.12a3.47 3.47 0 01-.905-2.34H6.963c0 1.267.47 2.483 1.324 3.42z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
