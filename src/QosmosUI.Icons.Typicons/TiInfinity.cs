// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiInfinity : ComponentBase
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
		builder.AddAttribute(14, "d", "M16.433 8.596c-1.153 0-2.237.449-3.036 1.246l-1.396 1.34-1.375-1.32c-.815-.817-1.901-1.266-3.055-1.266-1.154 0-2.239.451-3.053 1.266-.817.816-1.267 1.9-1.267 3.055 0 1.152.449 2.238 1.266 3.053.814.816 1.899 1.266 3.054 1.266 1.153 0 2.239-.449 3.036-1.248l1.395-1.338 1.376 1.32c.815.816 1.901 1.266 3.055 1.266s2.238-.449 3.053-1.266c.817-.814 1.267-1.9 1.267-3.055s-.449-2.238-1.266-3.055c-.817-.815-1.901-1.264-3.054-1.264zm-7.576 5.605c-.687.688-1.884.688-2.572 0-.344-.344-.533-.801-.533-1.285 0-.486.189-.941.535-1.287.342-.344.799-.533 1.284-.533s.942.189 1.305.551l1.321 1.27-1.34 1.284zm8.861 0c-.687.689-1.866.705-2.59-.018l-1.321-1.27 1.339-1.285c.688-.688 1.886-.688 2.573-.002.344.346.533.801.533 1.287s-.19.944-.534 1.288z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
