// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTorpedo : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M40 47c-9.282 0-17 7.718-17 17s7.718 17 17 17 17-7.718 17-17-7.718-17-17-17zm0 16c.446 0 1 .554 1 1 0 .446-.554 1-1 1-.446 0-1-.554-1-1 0-.446.554-1 1-1zm48 48c-9.282 0-17 7.718-17 17s7.718 17 17 17 17-7.718 17-17-7.718-17-17-17zm0 16c.446 0 1 .554 1 1 0 .446-.554 1-1 1-.446 0-1-.554-1-1 0-.446.554-1 1-1zm-40 40c-13.7 0-25 11.3-25 25s11.3 25 25 25 25-11.3 25-25-11.3-25-25-25zm0 18c3.973 0 7 3.027 7 7s-3.027 7-7 7-7-3.027-7-7 3.027-7 7-7zm52.23 32l13 39-13 39h26.514v-78H100.23zm164.622 0l-120.108 30.025v17.948L264.852 295h117.892v-78H264.852zm135.892 0v78h30v-78h-30zm48 0v78h5.684c28.584-7.435 40.316-23.962 40.316-39s-11.732-31.565-40.316-39h-5.684z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
