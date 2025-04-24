// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiStadia : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.5253 10.0302a18.279 18.279 0 0 1 15.7805.263c.263.1973.6575 0 .7233-.263l.9205-2.8273c.1315-.263 0-.6576-.3288-.789A22.3557 22.3557 0 0 0 .2788 8.6493a.6575.6575 0 0 0-.1972.8548l2.1698 4.7999c.1315.3287.526.526.8548.3945 2.4328-.9205 6.1807-1.841 9.9943-1.315-2.63.4602-4.6684 1.3807-6.3122 2.367a.6575.6575 0 0 0-.1972.8548L7.906 19.63c.1315.263.4603.3288.6575.1315.526-.526 1.052-.9205 1.5123-1.1835 2.104-1.1836 4.9972-2.1041 8.8765-1.9068a.6575.6575 0 0 0 .6576-.4603l.9862-2.9589c.1316-.263 0-.6575-.263-.789a20.0544 20.0544 0 0 0-13.8737-2.4328z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
