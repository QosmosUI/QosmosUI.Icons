// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiPipette : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M21.384 7.331c.073-1.199-.354-2.388-1.146-3.179-.732-.731-1.793-1.152-2.912-1.152-1.176 0-2.206.453-2.825 1.243-.692.883-1.392 2.625-1.769 3.647l-1.616-1.617c-.392-.391-1.023-.391-1.414 0-.392.392-.392 1.023 0 1.414l.293.293-5.231 5.232c-.375.375-.719.912-.968 1.516-.019.043-1.726 4.328-.093 5.959.527.526 1.33.707 2.178.707 1.778-.002 3.753-.787 3.783-.801.602-.248 1.141-.592 1.514-.967l5.232-5.232.293.293c.195.195.451.293.707.293s.512-.098.707-.293c.391-.391.391-1.022 0-1.414l-1.617-1.616c1.023-.376 2.766-1.075 3.648-1.769.721-.562 1.17-1.493 1.236-2.557zm-16.265 11.944c-.247-.295-.105-1.508.154-2.58l2.422 2.423c-1.071.261-2.283.403-2.576.157zm4.645-1.061c-.188.188-.511.388-.865.533l-.116.042-3.181-3.18.043-.117c.146-.354.346-.678.533-.864l5.232-5.231 3.586 3.586-5.232 5.231z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
