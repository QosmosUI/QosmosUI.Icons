// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscLiveShare : ComponentBase
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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M13.735 1.694L15.178 1l8.029 6.328v1.388l-8.029 6.072-1.443-.694v-2.776h-.59c-4.06-.02-6.71.104-10.61 5.163l-1.534-.493a8.23 8.23 0 0 1 .271-2.255 11.026 11.026 0 0 1 3.92-6.793 11.339 11.339 0 0 1 7.502-2.547h1.04v-2.7zm1.804 7.917v2.776l5.676-4.281-5.648-4.545v2.664h-2.86A9.299 9.299 0 0 0 5.77 8.848a10.444 10.444 0 0 0-2.401 4.122c3.351-3.213 6.19-3.359 9.798-3.359h2.373zm-7.647 5.896a4.31 4.31 0 1 1 4.788 7.166 4.31 4.31 0 0 1-4.788-7.166zm.955 5.728a2.588 2.588 0 1 0 2.878-4.302 2.588 2.588 0 0 0-2.878 4.302z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
