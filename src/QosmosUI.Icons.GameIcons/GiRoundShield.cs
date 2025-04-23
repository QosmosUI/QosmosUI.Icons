// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiRoundShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M261.563 64.28A191.758 191.758 0 0 0 64.25 256a191.758 191.758 0 1 0 383.5 0A191.758 191.758 0 0 0 261.562 64.28zm-4.625 9.126l8.937 5.156v10.313l-8.938 5.156-8.906-5.155V78.562l8.907-5.156zm3.53 29.25A153.407 153.407 0 0 1 409.407 256a153.407 153.407 0 0 1-306.812 0A153.407 153.407 0 0 1 260.47 102.656zm-11.53 20.03a133.607 133.607 0 0 0-65.157 20.908V368.22a133.607 133.607 0 0 0 65.157 21.092V122.688zm17.687.314v266.125a133.607 133.607 0 0 0 63.438-22.03V145a133.607 133.607 0 0 0-63.438-22zm-100.5 34.344A133.607 133.607 0 0 0 122.405 256a133.607 133.607 0 0 0 43.72 98.78V157.345zm-60.72 1.625l8.907 5.155v10.28l-8.906 5.157-8.937-5.156v-10.28l8.936-5.157zm300.5 0l8.94 5.155v10.28l-8.94 5.157-8.905-5.156v-10.28l8.906-5.157zm-58.155.093V353.03A133.607 133.607 0 0 0 389.594 256a133.607 133.607 0 0 0-41.844-96.938zm57.813 173.125l8.937 5.156v10.312l-8.938 5.156-8.906-5.156v-10.312l8.906-5.156zm-299.813.718l8.938 5.156v10.313l-8.938 5.156-8.938-5.155v-10.313l8.938-5.156zm149.906 85.188l8.938 5.156v10.313l-8.938 5.156-8.906-5.158V423.25l8.906-5.156z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
