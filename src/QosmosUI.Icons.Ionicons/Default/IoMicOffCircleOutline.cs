// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoMicOffCircleOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M256,464C141.31,464,48,370.69,48,256S141.31,48,256,48s208,93.31,208,208S370.69,464,256,464Zm0-384C159,80,80,159,80,256S159,432,256,432s176-78.95,176-176S353.05,80,256,80Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M352,369a15.93,15.93,0,0,1-11.84-5.24l-192-210a16,16,0,0,1,23.68-21.52l192,210A16,16,0,0,1,352,369Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M352,248.22v-23.8a16.3,16.3,0,0,0-13.64-16.24C328.48,206.7,320,214.69,320,224.3v23.92a43.35,43.35,0,0,1-3.07,15.91,4,4,0,0,0,.76,4.16l19.19,21.1a2,2,0,0,0,3.19-.3A77.12,77.12,0,0,0,352,248.22Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M304,240V176a48.14,48.14,0,0,0-48-48h0a48.08,48.08,0,0,0-41,23.1,4,4,0,0,0,.47,4.77l84.42,92.86a2,2,0,0,0,3.46-1A47.84,47.84,0,0,0,304,240Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M246.57,285.2l-36.46-40.11a1,1,0,0,0-1.74.8,48.26,48.26,0,0,0,37.25,41A1,1,0,0,0,246.57,285.2Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M287.55,352H272V334.26a100.33,100.33,0,0,0,12.53-3.06,2,2,0,0,0,.89-3.26l-21.07-23.19a3.94,3.94,0,0,0-3.29-1.29c-1.69.15-3.39.24-5.06.24-36,0-64-29.82-64-55.48V224.4A16.26,16.26,0,0,0,176.39,208,15.91,15.91,0,0,0,160,224v24.22c0,23.36,10.94,45.61,30.79,62.66A103.71,103.71,0,0,0,240,334.26V352H224.45c-8.61,0-16,6.62-16.43,15.23A16,16,0,0,0,224,384h64a16,16,0,0,0,16-16.77C303.58,358.62,296.16,352,287.55,352Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
