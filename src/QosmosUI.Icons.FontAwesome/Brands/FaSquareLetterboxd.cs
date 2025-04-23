// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaSquareLetterboxd : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M384 32c35.3 0 64 28.7 64 64V416c0 35.3-28.7 64-64 64H64c-35.3 0-64-28.7-64-64V96C0 60.7 28.7 32 64 32H384zM105.1 187C66.4 187 35 218.3 35 257s31.4 70 70.1 70c24.8 0 46.5-12.8 59-32.2l.5-.7-.4-.6c-6.5-10.6-10.2-23.1-10.2-36.5c0-13.6 3.9-26.3 10.6-37.1c-12.4-19.8-34.4-32.9-59.5-32.9zM224 187c-24.8 0-46.5 12.8-59 32.2l-.5 .7 .4 .6c6.5 10.6 10.2 23.1 10.2 36.5c0 13.6-3.9 26.3-10.6 37.1C176.9 313.8 198.9 327 224 327c24.8 0 46.5-12.8 59-32.2l.5-.7-.4-.6c-6.5-10.6-10.2-23.1-10.2-36.5c0-13.6 3.9-26.3 10.6-37.1C271.1 200.2 249.1 187 224 187zm118.9 0c-24.8 0-46.5 12.8-59 32.2l-.5 .7 .4 .6c6.5 10.6 10.2 23.1 10.2 36.5c0 13.6-3.9 26.3-10.6 37.1c12.4 19.8 34.4 32.9 59.5 32.9c38.7 0 70.1-31.3 70.1-70s-31.4-70-70.1-70z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
