// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNailedHead : ComponentBase
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
		builder.AddAttribute(14, "d", "M206.28 20.75l40.75 18.406v95.625l11 17.907 12.75-17.906V39.157l40.75-18.406H206.28zm-81.874 32.28L49.97 127.438l41.843-15.78 67.624 67.624 21.657 3.657-4.875-20.468-67.626-67.595 15.812-41.844zm264.281 0l15.782 41.845-67.626 67.594-4.875 20.468 21.686-3.657 67.594-67.624 41.844 15.78-74.406-74.405zM258.281 167.47c-18.774 0-35.987 9.647-49 26.28-13.01 16.633-21.374 40.158-21.374 66.313 0 27.096 9.278 51.387 23.188 68.156l10.125 12.217-15.595 2.938c-39.857 7.504-58.408 22.664-69.28 48.25-10.143 23.866-12.33 58.635-12.595 103.094h270.406c-.04-44.852-.605-80.457-9.812-104.626-9.865-25.894-27.82-41.064-71.28-47.906l-15.845-2.5 10-12.563c13.226-16.583 21.436-40.478 21.436-67.063 0-26.153-8.363-49.68-21.375-66.312-13.01-16.633-30.224-26.28-49-26.28zM35.407 206.78V312l18.438-40.75h95.594l17.906-12.72-17.906-11H53.844l-18.438-40.75zm446.97 0l-18.407 40.75h-95.626l-17.906 11 17.906 12.72h95.625L482.374 312V206.78z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
